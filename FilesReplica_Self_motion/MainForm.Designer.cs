
namespace FilesReplica_Self_motion
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uC_TaskRun1 = new FilesReplica_Self_motion.UCControls.UC_TaskRun();
            this.SuspendLayout();
            // 
            // uC_TaskRun1
            // 
            this.uC_TaskRun1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.uC_TaskRun1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_TaskRun1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uC_TaskRun1.Location = new System.Drawing.Point(0, 0);
            this.uC_TaskRun1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_TaskRun1.Name = "uC_TaskRun1";
            this.uC_TaskRun1.Size = new System.Drawing.Size(853, 470);
            this.uC_TaskRun1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(853, 470);
            this.Controls.Add(this.uC_TaskRun1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "文件自动拷贝";
            this.ResumeLayout(false);

        }

        #endregion

        private UCControls.UC_TaskRun uC_TaskRun1;
    }
}

