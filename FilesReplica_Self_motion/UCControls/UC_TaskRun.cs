using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesReplica_Self_motion.UCControls
{
    public partial class UC_TaskRun : UserControl
    {
        /// <summary>
        /// 定义初始的全局变量
        /// </summary>
        string yuan_explorerPath = "";
        string yuan_treeViewPath = "";        
        string mb_explorerPath = "";
        string mb_treeViewPath = "";


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

    }
}
