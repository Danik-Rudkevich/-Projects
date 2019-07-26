namespace LoginAtor
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.TBRead = new System.Windows.Forms.TextBox();
            this.TBWrite = new System.Windows.Forms.TextBox();
            this.PBStart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBStart)).BeginInit();
            this.SuspendLayout();
            // 
            // TBRead
            // 
            this.TBRead.BackColor = System.Drawing.SystemColors.MenuText;
            this.TBRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBRead.ForeColor = System.Drawing.Color.Lime;
            this.TBRead.Location = new System.Drawing.Point(12, 179);
            this.TBRead.Name = "TBRead";
            this.TBRead.Size = new System.Drawing.Size(263, 29);
            this.TBRead.TabIndex = 0;
            // 
            // TBWrite
            // 
            this.TBWrite.BackColor = System.Drawing.SystemColors.MenuText;
            this.TBWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBWrite.ForeColor = System.Drawing.Color.Lime;
            this.TBWrite.Location = new System.Drawing.Point(426, 179);
            this.TBWrite.Name = "TBWrite";
            this.TBWrite.Size = new System.Drawing.Size(263, 29);
            this.TBWrite.TabIndex = 1;
            this.TBWrite.DoubleClick += new System.EventHandler(this.TBWrite_DoubleClick);
            // 
            // PBStart
            // 
            this.PBStart.BackColor = System.Drawing.Color.Transparent;
            this.PBStart.Location = new System.Drawing.Point(281, 126);
            this.PBStart.Name = "PBStart";
            this.PBStart.Size = new System.Drawing.Size(139, 130);
            this.PBStart.TabIndex = 2;
            this.PBStart.TabStop = false;
            this.PBStart.Click += new System.EventHandler(this.PBStart_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginAtor.Properties.Resources.kompyutery_apple_yabloko_fon_tyomnyj_log_588004;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 379);
            this.Controls.Add(this.PBStart);
            this.Controls.Add(this.TBWrite);
            this.Controls.Add(this.TBRead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "^%$#%^&";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PBStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBRead;
        private System.Windows.Forms.TextBox TBWrite;
        private System.Windows.Forms.PictureBox PBStart;
    }
}