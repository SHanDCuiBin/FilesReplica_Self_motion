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
        private static IntPtr m_ipSmallSystemImageList;
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
            }
        }

        private void backLoad_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void UC_TaskRun_Load(object sender, EventArgs e)
        {
            //获取系统 ImageList
            SHFILEINFO shfi = new SHFILEINFO();

            m_ipSmallSystemImageList = API.SHGetFileInfo("", 0, out shfi, Marshal.SizeOf(typeof(SHFILEINFO)),
                SHGFI.SYSICONINDEX | SHGFI.SMALLICON | SHGFI.USEFILEATTRIBUTES);

            m_ipLargeSystemImageList = API.SHGetFileInfo("", 0, out shfi, Marshal.SizeOf(typeof(SHFILEINFO)),
                SHGFI.SYSICONINDEX | SHGFI.LARGEICON | SHGFI.USEFILEATTRIBUTES);

            //把系统 ImageList 关联到 TreeView 和 ListView
            API.SendMessage(treeView_Yun.Handle, API.TVM_SETIMAGELIST, API.TVSIL_NORMAL, m_ipSmallSystemImageList);
           // API.SendMessage(lvFile.Handle, API.LVM_SETIMAGELIST, API.LVSIL_NORMAL, m_ipLargeSystemImageList);

            //获得桌面 PIDL
            IntPtr deskTopPtr;
            iDeskTop = API.GetDesktopFolder(out deskTopPtr);
            API.SHGetSpecialFolderLocation(IntPtr.Zero, CSIDL.DESKTOP, out deskTopPtr);

            //添加 桌面 节点
            int imgIndex = API.GetSmallIconIndex(deskTopPtr);
            TreeNode tnDesktop = new TreeNode("桌面", imgIndex, imgIndex);
            tnDesktop.Tag = new ShellItem(deskTopPtr, iDeskTop);
            tnDesktop.Nodes.Add("...");

            //把节点添加到树中
            treeView_Yun.Nodes.Add(tnDesktop);
            treeView_Yun.SelectedNode = tnDesktop;
            tnDesktop.Expand();
        }
    }
}
