namespace Game_the_basis
{
    partial class frmpreglavn
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
            this.pb_start = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_who = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_who)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_start
            // 
            this.pb_start.BackColor = System.Drawing.Color.Transparent;
            this.pb_start.BackgroundImage = global::Game_the_basis.Properties.Resources.button_start;
            this.pb_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_start.Location = new System.Drawing.Point(255, 39);
            this.pb_start.Name = "pb_start";
            this.pb_start.Size = new System.Drawing.Size(122, 51);
            this.pb_start.TabIndex = 0;
            this.pb_start.TabStop = false;
            this.pb_start.Click += new System.EventHandler(this.pb_start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Game_the_basis.Properties.Resources.button_close;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(255, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 51);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_who
            // 
            this.pb_who.BackColor = System.Drawing.Color.Transparent;
            this.pb_who.BackgroundImage = global::Game_the_basis.Properties.Resources.button_who;
            this.pb_who.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_who.Location = new System.Drawing.Point(57, 136);
            this.pb_who.Name = "pb_who";
            this.pb_who.Size = new System.Drawing.Size(105, 52);
            this.pb_who.TabIndex = 2;
            this.pb_who.TabStop = false;
            this.pb_who.Visible = false;
            this.pb_who.Click += new System.EventHandler(this.pb_who_Click);
            // 
            // frmpreglavn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_the_basis.Properties.Resources._3390781_0bc4013890f8ac38;
            this.ClientSize = new System.Drawing.Size(449, 344);
            this.Controls.Add(this.pb_who);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmpreglavn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pb_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_who)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_who;

    }
}