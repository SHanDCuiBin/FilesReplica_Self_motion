using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinShell;

namespace FilesReplica_Self_motion.UCControls
{
    public partial class UC_TaskRun : UserControl
    {
        private IShellFolder iDeskTop;
        private static IntPtr m_ipLargeSystemImageList;


        public UC_TaskRun()
        {
            InitializeComponent();
        }


        #region 设置边框颜色
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                                        this.panel1.ClientRectangle,
                                        Color.DarkCyan,//7f9db9
                                        1,
                                        ButtonBorderStyle.Solid,
                                        Color.DarkCyan,
                                        1,
                                        ButtonBorderStyle.Solid,
                                        Color.DarkCyan,
                                        1,
                                        ButtonBorderStyle.Solid,
                                        Color.DarkCyan,
                                        1,
                                        ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                                        this.panel2.ClientRectangle,
                                        Color.Pink,//7f9db9
                                        1,
                                        ButtonBorderStyle.Solid,
                                        Color.Pink,
                                        1,
                                        ButtonBorderStyle.Solid,
                                        Color.Pink,
                                        1,
                                        ButtonBorderStyle.Solid,
                                        Color.Pink,
                                        1,
                                        ButtonBorderStyle.Solid);
        }
        #endregion


        /// <summary>
        /// 定时任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 选择 源 文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Yuan_LL_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_yuanFilePath.Text = dialog.SelectedPath;

                ShellItem ShellItem = GetShellItemByPath(txt_yuanFilePath.Text);
                FillListView(ShellItem, listView_Yuan);
            }
        }

        /// <summary>
        /// 选择 目标 文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mb_LL_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_mbFilePath.Text = dialog.SelectedPath;

                ShellItem ShellItem = GetShellItemByPath(txt_mbFilePath.Text);
                FillListView(ShellItem, listView_mb);
            }
        }

        private void backLoad_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        /// <summary>
        /// 程序加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_TaskRun_Load(object sender, EventArgs e)
        {
            //获取系统 ImageList
            SHFILEINFO shfi = new SHFILEINFO();
            m_ipLargeSystemImageList = API.SHGetFileInfo("", 0, out shfi, Marshal.SizeOf(typeof(SHFILEINFO)),
                SHGFI.SYSICONINDEX | SHGFI.LARGEICON | SHGFI.USEFILEATTRIBUTES);

            API.SendMessage(listView_Yuan.Handle, API.LVM_SETIMAGELIST, API.LVSIL_NORMAL, m_ipLargeSystemImageList);
            API.SendMessage(listView_mb.Handle, API.LVM_SETIMAGELIST, API.LVSIL_NORMAL, m_ipLargeSystemImageList);

            //获得桌面 PIDL
            IntPtr deskTopPtr;
            iDeskTop = API.GetDesktopFolder(out deskTopPtr);
            API.SHGetSpecialFolderLocation(IntPtr.Zero, CSIDL.DESKTOP, out deskTopPtr);

            ShellItem sItem = new ShellItem(deskTopPtr, iDeskTop);

            FillListView(sItem, listView_Yuan);
            FillListView(sItem, listView_mb);

        }



        private ShellItem GetShellItemByPath(string path)
        {
            IntPtr deskTopPtr;
            iDeskTop = API.GetShellFolder(API.GetDesktopFolder(out deskTopPtr), path);
            API.SHGetSpecialFolderLocation(IntPtr.Zero, CSIDL.DESKTOP, out deskTopPtr);
            return new ShellItem(deskTopPtr, iDeskTop);
        }

        /// <summary>
        /// 填充指定容器内容
        /// </summary>
        /// <param name="sItem"></param>
        private void FillListView(ShellItem sItem, ListView lsView)
        {
            IShellFolder root = sItem.ShellFolder;

            lsView.Items.Clear();

            //循环查找子项
            IEnumIDList Enum = null;
            IntPtr EnumPtr = IntPtr.Zero;
            IntPtr pidlSub;
            int celtFetched;

            if (root.EnumObjects(this.Handle, SHCONTF.FOLDERS | SHCONTF.INCLUDEHIDDEN, out EnumPtr) == API.S_OK)
            {
                Enum = (IEnumIDList)Marshal.GetObjectForIUnknown(EnumPtr);
                while (Enum.Next(1, out pidlSub, out celtFetched) == 0 && celtFetched == API.S_FALSE)
                {
                    string name = API.GetNameByIShell(root, pidlSub);
                    ShellItem shellItem = new ShellItem(pidlSub, null, sItem);

                    ListViewItem item = new ListViewItem(name,
                        API.GetLargeIconIndex(shellItem.PIDLFull.Ptr));
                    item.Tag = shellItem;
                    lsView.Items.Add(item);
                }
            }

            if (root.EnumObjects(this.Handle, SHCONTF.NONFOLDERS | SHCONTF.INCLUDEHIDDEN, out EnumPtr) == API.S_OK)
            {
                Enum = (IEnumIDList)Marshal.GetObjectForIUnknown(EnumPtr);
                while (Enum.Next(1, out pidlSub, out celtFetched) == 0 && celtFetched == API.S_FALSE)
                {
                    SFGAO attribs = SFGAO.FOLDER;
                    root.GetAttributesOf(1, new IntPtr[] { pidlSub }, ref attribs);
                    if ((attribs & SFGAO.FOLDER) == 0)
                    {
                        string name = API.GetNameByIShell(root, pidlSub);
                        string path = API.GetPathByIShell(root, pidlSub);
                        ShellItem shellItem = new ShellItem(pidlSub, null, sItem);

                        ListViewItem item = new ListViewItem(name,
                            API.GetLargeIconIndex(shellItem.PIDLFull.Ptr));
                        item.Tag = shellItem;
                        lsView.Items.Add(item);
                    }
                }
            }

            lsView.Sort();
        }

        /// <summary>
        /// 【暂停】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        /// <summary>
        /// 【重启】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }
    }
}
