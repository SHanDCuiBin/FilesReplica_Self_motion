
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
            this.listView_Yuan = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView_mb = new System.Windows.Forms.ListView();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_yuanFilePath = new System.Windows.Forms.TextBox();
            this.txt_mbFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_Yuan_LL = new System.Windows.Forms.Button();
            this.btn_mb_LL = new System.Windows.Forms.Button();
            this.backLoad = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.labMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView_Yuan);
            this.panel1.Location = new System.Drawing.Point(6, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(395, 372);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listView_Yuan
            // 
            this.listView_Yuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Yuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Yuan.HideSelection = false;
            this.listView_Yuan.Location = new System.Drawing.Point(1, 1);
            this.listView_Yuan.Name = "listView_Yuan";
            this.listView_Yuan.Size = new System.Drawing.Size(393, 370);
            this.listView_Yuan.TabIndex = 0;
            this.listView_Yuan.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView_mb);
            this.panel2.Location = new System.Drawing.Point(452, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(395, 372);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listView_mb
            // 
            this.listView_mb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_mb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_mb.HideSelection = false;
            this.listView_mb.Location = new System.Drawing.Point(1, 1);
            this.listView_mb.Name = "listView_mb";
            this.listView_mb.Size = new System.Drawing.Size(393, 370);
            this.listView_mb.TabIndex = 1;
            this.listView_mb.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Reset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Reset.Location = new System.Drawing.Point(346, 438);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Padding = new System.Windows.Forms.Padding(2);
            this.btn_Reset.Size = new System.Drawing.Size(70, 30);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "重 启";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Stop.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Stop.FlatAppearance.BorderSize = 0;
            this.btn_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Stop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Stop.Location = new System.Drawing.Point(433, 438);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Padding = new System.Windows.Forms.Padding(2);
            this.btn_Stop.Size = new System.Drawing.Size(70, 30);
            this.btn_Stop.TabIndex = 11;
            this.btn_Stop.Text = "暂 停";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
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
            this.txt_mbFilePath.Location = new System.Drawing.Point(493, 7);
            this.txt_mbFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mbFilePath.Name = "txt_mbFilePath";
            this.txt_mbFilePath.ReadOnly = true;
            this.txt_mbFilePath.Size = new System.Drawing.Size(284, 25);
            this.txt_mbFilePath.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "目标目录";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btn_Yuan_LL.Location = new System.Drawing.Point(343, 5);
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
            this.btn_mb_LL.BackColor = System.Drawing.Color.Coral;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "源文件总数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "目标文件总数：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 439);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 28);
            this.comboBox1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "文件类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "频率：";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(243, 441);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 25);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "S/次";
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.Location = new System.Drawing.Point(591, 443);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(107, 20);
            this.labMessage.TabIndex = 25;
            this.labMessage.Text = "正在执行。。。";
            // 
            // UC_TaskRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.labMessage);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_mb_LL);
            this.Controls.Add(this.btn_Yuan_LL);
            this.Controls.Add(this.txt_mbFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_yuanFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_TaskRun";
            this.Size = new System.Drawing.Size(853, 470);
            this.Load += new System.EventHandler(this.UC_TaskRun_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_yuanFilePath;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_Yuan_LL;
        private System.Windows.Forms.Button btn_mb_LL;
        private System.Windows.Forms.TextBox txt_mbFilePath;
        private System.ComponentModel.BackgroundWorker backLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView_Yuan;
        private System.Windows.Forms.ListView listView_mb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labMessage;
    }
}
