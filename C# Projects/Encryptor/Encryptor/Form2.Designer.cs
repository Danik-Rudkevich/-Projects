namespace Encryptor
{
    partial class Frm_Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Help));
            this.Rtb_read = new System.Windows.Forms.RichTextBox();
            this.Rtb_write = new System.Windows.Forms.RichTextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rtb_read
            // 
            this.Rtb_read.Location = new System.Drawing.Point(12, 12);
            this.Rtb_read.Name = "Rtb_read";
            this.Rtb_read.Size = new System.Drawing.Size(330, 361);
            this.Rtb_read.TabIndex = 0;
            this.Rtb_read.Text = "";
            // 
            // Rtb_write
            // 
            this.Rtb_write.Location = new System.Drawing.Point(431, 12);
            this.Rtb_write.Name = "Rtb_write";
            this.Rtb_write.Size = new System.Drawing.Size(330, 361);
            this.Rtb_write.TabIndex = 1;
            this.Rtb_write.Text = "";
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Adobe Arabic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(12, 379);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(749, 73);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Анализ";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Frm_Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 464);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.Rtb_write);
            this.Controls.Add(this.Rtb_read);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Help";
            this.Text = "Анализатор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtb_read;
        private System.Windows.Forms.RichTextBox Rtb_write;
        private System.Windows.Forms.Button BtnStart;
    }
}