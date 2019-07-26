namespace SuperGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbFirstMass = new System.Windows.Forms.TextBox();
            this.tbSecondMass = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PbStart = new System.Windows.Forms.PictureBox();
            this.cbInsert = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbStart)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFirstMass
            // 
            this.tbFirstMass.Location = new System.Drawing.Point(754, 27);
            this.tbFirstMass.Name = "tbFirstMass";
            this.tbFirstMass.Size = new System.Drawing.Size(425, 20);
            this.tbFirstMass.TabIndex = 0;
            this.tbFirstMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstMass_KeyPress);
            // 
            // tbSecondMass
            // 
            this.tbSecondMass.Location = new System.Drawing.Point(754, 66);
            this.tbSecondMass.Name = "tbSecondMass";
            this.tbSecondMass.Size = new System.Drawing.Size(425, 20);
            this.tbSecondMass.TabIndex = 1;
            this.tbSecondMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSecondMass_KeyPress);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbOutput.Location = new System.Drawing.Point(12, 335);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(1167, 308);
            this.rtbOutput.TabIndex = 2;
            this.rtbOutput.Text = "";
            this.rtbOutput.DoubleClick += new System.EventHandler(this.rtbOutput_DoubleClick);
            // 
            // rtbInput
            // 
            this.rtbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbInput.Location = new System.Drawing.Point(12, 27);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(736, 289);
            this.rtbInput.TabIndex = 4;
            this.rtbInput.Text = "";
            this.rtbInput.DoubleClick += new System.EventHandler(this.rtbInput_DoubleClick);
            this.rtbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Шаблон:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вывод:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(751, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Диапазон от:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(754, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Диапазон до:";
            // 
            // tbRandom
            // 
            this.tbRandom.Location = new System.Drawing.Point(757, 114);
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.Size = new System.Drawing.Size(422, 20);
            this.tbRandom.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Диапазон для случайных вставок:";
            // 
            // PbStart
            // 
            this.PbStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbStart.Image = global::SuperGenerator.Properties.Resources.kisspng_computer_icons_button_download_clip_art_press_cliparts_5aaa80b5d6cd76_1481213115211235098798;
            this.PbStart.Location = new System.Drawing.Point(757, 163);
            this.PbStart.Name = "PbStart";
            this.PbStart.Size = new System.Drawing.Size(422, 166);
            this.PbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbStart.TabIndex = 11;
            this.PbStart.TabStop = false;
            this.PbStart.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbInsert
            // 
            this.cbInsert.AutoSize = true;
            this.cbInsert.Location = new System.Drawing.Point(757, 140);
            this.cbInsert.Name = "cbInsert";
            this.cbInsert.Size = new System.Drawing.Size(373, 17);
            this.cbInsert.TabIndex = 12;
            this.cbInsert.Text = "Подставлять значения из диапозона случайных вставок по порядку";
            this.cbInsert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 655);
            this.Controls.Add(this.cbInsert);
            this.Controls.Add(this.PbStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRandom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.tbSecondMass);
            this.Controls.Add(this.tbFirstMass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SuperGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.PbStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstMass;
        private System.Windows.Forms.TextBox tbSecondMass;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PbStart;
        private System.Windows.Forms.CheckBox cbInsert;
    }
}

