namespace BackUper
{
    partial class Glavn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavn));
            this.pbLong = new System.Windows.Forms.PictureBox();
            this.pbFast = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFast)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLong
            // 
            this.pbLong.BackgroundImage = global::BackUper.Properties.Resources._6820ae63b220cef4813ea8db90177d09;
            this.pbLong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLong.Location = new System.Drawing.Point(12, 246);
            this.pbLong.Name = "pbLong";
            this.pbLong.Size = new System.Drawing.Size(221, 228);
            this.pbLong.TabIndex = 1;
            this.pbLong.TabStop = false;
            this.pbLong.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbFast
            // 
            this.pbFast.BackgroundImage = global::BackUper.Properties.Resources.FastBackUp;
            this.pbFast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFast.Location = new System.Drawing.Point(12, 12);
            this.pbFast.Name = "pbFast";
            this.pbFast.Size = new System.Drawing.Size(221, 228);
            this.pbFast.TabIndex = 0;
            this.pbFast.TabStop = false;
            this.pbFast.Click += new System.EventHandler(this.pbFast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логи:";
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbLog.Location = new System.Drawing.Point(243, 33);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(663, 409);
            this.rtbLog.TabIndex = 3;
            this.rtbLog.Text = "";
            // 
            // pbProgress
            // 
            this.pbProgress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbProgress.ForeColor = System.Drawing.Color.Lime;
            this.pbProgress.Location = new System.Drawing.Point(243, 449);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(663, 23);
            this.pbProgress.TabIndex = 4;
            this.pbProgress.Visible = false;
            // 
            // Glavn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(912, 482);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLong);
            this.Controls.Add(this.pbFast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Glavn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavn";
            ((System.ComponentModel.ISupportInitialize)(this.pbLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFast;
        private System.Windows.Forms.PictureBox pbLong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.FolderBrowserDialog fbd;
    }
}

