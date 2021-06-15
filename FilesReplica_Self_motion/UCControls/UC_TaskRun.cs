using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (!string.IsNullOrEmpty(txt_yuanFilePath.Text) && !string.IsNullOrEmpty(txt_mbFilePath.Text))
            {
                if (pic_yuanTomb)              //源文件夹 往 目标文件夹 拷贝
                {
                    try
                    {
                        DirectoryInfo yuanFolder = new DirectoryInfo(txt_yuanFilePath.Text);
                        foreach (FileInfo NextFile in yuanFolder.GetFiles())
                        {
                            if (!string.IsNullOrEmpty(cboxFilesType.Text) && !isAddListView(NextFile.Name))
                            {
                                continue;
                            }
                            if (!File.Exists(txt_mbFilePath.Text + "\\" + NextFile.Name))
                            {
                                if (!Directory.Exists(txt_mbFilePath.Text))
                                {
                                    DirectoryInfo dir = new DirectoryInfo(txt_mbFilePath.Text);
                                    dir.Create();
                                }

                                string[] info = new string[] { txt_yuanFilePath.Text, txt_mbFilePath.Text, NextFile.Name };
                                if (!backLoad.IsBusy)
                                {
                                    backLoad.RunWorkerAsync(info);
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }

                if (pic_mbToyuan)              //目标文件夹 往 源文件夹 拷贝
                {
                    DirectoryInfo mbFolder = new DirectoryInfo(txt_mbFilePath.Text);
                    foreach (FileInfo NextFile in mbFolder.GetFiles())
                    {
                        if (!string.IsNullOrEmpty(cboxFilesType.Text) && !isAddListView(NextFile.Name))
                        {
                            continue;
                        }
                        if (!File.Exists(txt_mbFilePath.Text + "\\" + NextFile.Name))
                        {
                            if (!Directory.Exists(txt_yuanFilePath.Text))
                            {
                                DirectoryInfo dir = new DirectoryInfo(txt_yuanFilePath.Text);
                                dir.Create();
                            }

                            string[] info = new string[] { txt_mbFilePath.Text, txt_yuanFilePath.Text, NextFile.Name };
                            if (!backLoad.IsBusy)
                            {
                                backLoad.RunWorkerAsync(info);
                            }
                        }
                    }
                }
            }
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
                lab_yuan_sum.Text = "源文件总数：" + listView_Yuan.Items.Count;
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
                lab_mb_sum.Text = "目标文件总数：" + listView_mb.Items.Count;
            }
        }

        private void backLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] info = e.Argument as string[];
            string msg = "";
            bool result = CopyFilesToNewPath(info[0], info[1], info[2], out msg);
            e.Result = result.ToString() + "|" + msg;
        }

        private void backLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string result = e.Result as string;
            if (!string.IsNullOrEmpty(result))
            {
                string[] info = result.Split('|');
                if (info != null && info.Length == 2)
                {
                    if (info[0] == "true")
                    {

                    }
                }
            }
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
            lab_yuan_sum.Text = "源文件总数：" + listView_Yuan.Items.Count;
            FillListView(sItem, listView_mb);
            lab_mb_sum.Text = "目标文件总数：" + listView_mb.Items.Count;

        }


        /// <summary>
        /// 根据路径重新获得 ShellItem
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
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

                    if (isAddListView(name))         //判断是否需要显示
                    {
                        ListViewItem item = new ListViewItem(name,
                        API.GetLargeIconIndex(shellItem.PIDLFull.Ptr));
                        item.Tag = shellItem;
                        lsView.Items.Add(item);
                    }
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
                        //string path = API.GetPathByIShell(root, pidlSub);
                        ShellItem shellItem = new ShellItem(pidlSub, null, sItem);

                        if (isAddListView(name))      //判断是否需要显示
                        {
                            ListViewItem item = new ListViewItem(name,
                            API.GetLargeIconIndex(shellItem.PIDLFull.Ptr));
                            item.Tag = shellItem;
                            lsView.Items.Add(item);
                        }
                    }
                }
            }

            lsView.Sort();
        }

        /// <summary>
        /// 根据文件名称获取扩展名，然后判断是否需要显示
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool isAddListView(string name)
        {
            if (!string.IsNullOrEmpty(cboxFilesType.Text))
            {
                if (!string.IsNullOrEmpty(name))
                {
                    string fileExtension = GetFileExtension(name);
                    if (!string.IsNullOrEmpty(fileExtension) && fileExtension == cboxFilesType.Text)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                //未选择文件类型，则默认 全部显示
                return true;
            }
        }

        /// <summary>
        /// 根据文件名称获取文件的扩展名
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private string GetFileExtension(string fileName)
        {
            try
            {
                return Path.GetExtension(fileName);
            }
            catch (Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// 【暂停】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;

            cboxFilesType.Enabled = num_load_pl.Enabled = true;
        }

        /// <summary>
        /// 【重启】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            timer.Interval = int.Parse(num_load_pl.Value.ToString()) * 1000;
            timer.Enabled = true;
            cboxFilesType.Enabled = num_load_pl.Enabled = false;
        }

        bool pic_yuanTomb = false;
        bool pic_mbToyuan = false;
        private void picBox_yuanTomb_Click(object sender, EventArgs e)
        {
            if (!pic_yuanTomb)
            {
                picBox_yuanTomb.Image = Resource.箭头_右_绿;
                pic_yuanTomb = true;
            }
            else
            {
                picBox_yuanTomb.Image = Resource.箭头_右_黑;
                pic_yuanTomb = false;
            }
        }

        private void picBox_mbToyuan_Click(object sender, EventArgs e)
        {
            if (!pic_mbToyuan)
            {
                picBox_mbToyuan.Image = Resource.箭头_左_绿;
                pic_mbToyuan = true;
            }
            else
            {
                picBox_mbToyuan.Image = Resource.箭头_左_黑;
                pic_mbToyuan = false;
            }
        }

        /// <summary>
        /// 将文件 以流的方式从一个 路径 拷贝到 另一个 路径
        /// </summary>
        /// <param name="path_1"></param>
        /// <param name="path_2"></param>
        /// <param name="fileName"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        private bool CopyFilesToNewPath(string path_1, string path_2, string fileName, out string msg)
        {
            msg = "";
            try
            {
                //创建一个负责读取的流
                using (FileStream fsRead = new FileStream(path_1 + "\\" + fileName, FileMode.Open, FileAccess.Read))
                {
                    //创建一个负责写入的流
                    using (FileStream fsWrite = new FileStream(path_2 + "\\" + fileName, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        byte[] buffer = new byte[1024 * 1024 * 5];

                        //因为文件可能比较大所以在读取的时候应该用循坏去读取
                        while (true)
                        {
                            //返回本次实际读取到的字节数
                            int r = fsRead.Read(buffer, 0, buffer.Length);

                            if (r == 0)
                            {
                                break;
                            }
                            fsWrite.Write(buffer, 0, r);//写入
                        }

                    }
                }
                return true;
            }
            catch (Exception ee)
            {
                msg = ee.Message.ToString();
                return false;
            }
        }


    }
}
