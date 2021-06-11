
namespace FilesReplica_Self_motion.UCControls
{
    partial class UC_TaskRun
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView_Yun = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView_MB = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_yuanFilePath = new System.Windows.Forms.TextBox();
            this.txt_mbFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Yuan_LL = new System.Windows.Forms.Button();
            this.btn_mb_LL = new System.Windows.Forms.Button();
            this.backLoad = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView_Yun);
            this.panel1.Location = new System.Drawing.Point(6, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(385, 362);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // treeView_Yun
            // 
            this.treeView_Yun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView_Yun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Yun.Location = new System.Drawing.Point(1, 1);
            this.treeView_Yun.Name = "treeView_Yun";
            this.treeView_Yun.Size = new System.Drawing.Size(383, 360);
            this.treeView_Yun.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView_MB);
            this.panel2.Location = new System.Drawing.Point(427, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(420, 361);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // treeView_MB
            // 
            this.treeView_MB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView_MB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_MB.Location = new System.Drawing.Point(1, 1);
            this.treeView_MB.Name = "treeView_MB";
            this.treeView_MB.Size = new System.Drawing.Size(418, 359);
            this.treeView_MB.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(689, 435);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(2);
            this.button2.Size = new System.Drawing.Size(70, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "保 存";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(776, 435);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(2);
            this.button3.Size = new System.Drawing.Size(70, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "清 空";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "源目录";
            // 
            // txt_yuanFilePath
            // 
            this.txt_yuanFilePath.Location = new System.Drawing.Point(55, 7);
            this.txt_yuanFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_yuanFilePath.Name = "txt_yuanFilePath";
            this.txt_yuanFilePath.ReadOnly = true;
            this.txt_yuanFilePath.Size = new System.Drawing.Size(284, 25);
            this.txt_yuanFilePath.TabIndex = 13;
            // 
            // txt_mbFilePath
            // 
            this.txt_mbFilePath.Location = new System.Drawing.Point(489, 7);
            this.txt_mbFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mbFilePath.Name = "txt_mbFilePath";
            this.txt_mbFilePath.ReadOnly = true;
            this.txt_mbFilePath.Size = new System.Drawing.Size(284, 25);
            this.txt_mbFilePath.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "目标目录";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Yuan_LL
            // 
            this.btn_Yuan_LL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Yuan_LL.BackColor = System.Drawing.Color.Orange;
            this.btn_Yuan_LL.FlatAppearance.BorderSize = 0;
            this.btn_Yuan_LL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Yuan_LL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yuan_LL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Yuan_LL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Yuan_LL.Location = new System.Drawing.Point(342, 5);
            this.btn_Yuan_LL.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Yuan_LL.Name = "btn_Yuan_LL";
            this.btn_Yuan_LL.Size = new System.Drawing.Size(69, 28);
            this.btn_Yuan_LL.TabIndex = 16;
            this.btn_Yuan_LL.Text = "浏 览";
            this.btn_Yuan_LL.UseVisualStyleBackColor = false;
            this.btn_Yuan_LL.Click += new System.EventHandler(this.btn_Yuan_LL_Click);
            // 
            // btn_mb_LL
            // 
            this.btn_mb_LL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mb_LL.BackColor = System.Drawing.Color.Orange;
            this.btn_mb_LL.FlatAppearance.BorderSize = 0;
            this.btn_mb_LL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_mb_LL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mb_LL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_mb_LL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_mb_LL.Location = new System.Drawing.Point(781, 5);
            this.btn_mb_LL.Margin = new System.Windows.Forms.Padding(5);
            this.btn_mb_LL.Name = "btn_mb_LL";
            this.btn_mb_LL.Size = new System.Drawing.Size(69, 28);
            this.btn_mb_LL.TabIndex = 17;
            this.btn_mb_LL.Text = "浏 览";
            this.btn_mb_LL.UseVisualStyleBackColor = false;
            this.btn_mb_LL.Click += new System.EventHandler(this.btn_mb_LL_Click);
            // 
            // backLoad
            // 
            this.backLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backLoad_DoWork);
            // 
            // UC_TaskRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btn_mb_LL);
            this.Controls.Add(this.btn_Yuan_LL);
            this.Controls.Add(this.txt_mbFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_yuanFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_TaskRun";
            this.Size = new System.Drawing.Size(853, 470);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_yuanFilePath;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView_Yun;
        private System.Windows.Forms.TreeView treeView_MB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Yuan_LL;
        private System.Windows.Forms.Button btn_mb_LL;
        private System.Windows.Forms.TextBox txt_mbFilePath;
        private System.ComponentModel.BackgroundWorker backLoad;
    }
}
