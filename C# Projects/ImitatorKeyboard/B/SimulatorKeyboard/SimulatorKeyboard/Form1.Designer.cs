namespace SimulatorKeyboard
{
    partial class SimulatorKeyboard
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulatorKeyboard));
            this.label1 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPause = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PauseTimer = new System.Windows.Forms.Timer(this.components);
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.StopTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.TbR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TbYStart = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TbXStart = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TbEndY = new System.Windows.Forms.TextBox();
            this.TbEndX = new System.Windows.Forms.TextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клавиши:";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(70, 186);
            this.tb.Margin = new System.Windows.Forms.Padding(2);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(278, 20);
            this.tb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Задержка:";
            // 
            // tbPause
            // 
            this.tbPause.Location = new System.Drawing.Point(75, 215);
            this.tbPause.Margin = new System.Windows.Forms.Padding(2);
            this.tbPause.Name = "tbPause";
            this.tbPause.Size = new System.Drawing.Size(273, 20);
            this.tbPause.TabIndex = 4;
            this.tbPause.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SimulatorKeyboard.Properties.Resources.start_button;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(256, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 101);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PauseTimer
            // 
            this.PauseTimer.Tick += new System.EventHandler(this.PauseTimer_Tick);
            // 
            // StartTimer
            // 
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // StopTimer
            // 
            this.StopTimer.Tick += new System.EventHandler(this.StopTimer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Скорость работы:";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(108, 246);
            this.tbSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(240, 20);
            this.tbSpeed.TabIndex = 8;
            this.tbSpeed.Text = "1000";
            // 
            // TbR
            // 
            this.TbR.Location = new System.Drawing.Point(33, 29);
            this.TbR.Margin = new System.Windows.Forms.Padding(2);
            this.TbR.Name = "TbR";
            this.TbR.Size = new System.Drawing.Size(217, 20);
            this.TbR.TabIndex = 10;
            this.TbR.Text = "255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите цвет пикселей:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "R:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "G:";
            // 
            // TbG
            // 
            this.TbG.Location = new System.Drawing.Point(33, 53);
            this.TbG.Margin = new System.Windows.Forms.Padding(2);
            this.TbG.Name = "TbG";
            this.TbG.Size = new System.Drawing.Size(217, 20);
            this.TbG.TabIndex = 12;
            this.TbG.Text = "255";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "B:";
            // 
            // TbB
            // 
            this.TbB.Location = new System.Drawing.Point(35, 77);
            this.TbB.Margin = new System.Windows.Forms.Padding(2);
            this.TbB.Name = "TbB";
            this.TbB.Size = new System.Drawing.Size(215, 20);
            this.TbB.TabIndex = 14;
            this.TbB.Text = "255";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Введите координаты начала";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 155);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Y:";
            // 
            // TbYStart
            // 
            this.TbYStart.Location = new System.Drawing.Point(35, 152);
            this.TbYStart.Margin = new System.Windows.Forms.Padding(2);
            this.TbYStart.Name = "TbYStart";
            this.TbYStart.Size = new System.Drawing.Size(127, 20);
            this.TbYStart.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "X:";
            // 
            // TbXStart
            // 
            this.TbXStart.Location = new System.Drawing.Point(35, 128);
            this.TbXStart.Margin = new System.Windows.Forms.Padding(2);
            this.TbXStart.Name = "TbXStart";
            this.TbXStart.Size = new System.Drawing.Size(127, 20);
            this.TbXStart.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 113);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Введите координаты конца";
            // 
            // TbEndY
            // 
            this.TbEndY.Location = new System.Drawing.Point(221, 152);
            this.TbEndY.Margin = new System.Windows.Forms.Padding(2);
            this.TbEndY.Name = "TbEndY";
            this.TbEndY.Size = new System.Drawing.Size(127, 20);
            this.TbEndY.TabIndex = 25;
            // 
            // TbEndX
            // 
            this.TbEndX.Location = new System.Drawing.Point(221, 128);
            this.TbEndX.Margin = new System.Windows.Forms.Padding(2);
            this.TbEndX.Name = "TbEndX";
            this.TbEndX.Size = new System.Drawing.Size(127, 20);
            this.TbEndX.TabIndex = 24;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(354, 10);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(256, 255);
            this.rtbLog.TabIndex = 26;
            this.rtbLog.Text = "Логи:";
            // 
            // SimulatorKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 277);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.TbEndY);
            this.Controls.Add(this.TbEndX);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TbYStart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TbXStart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SimulatorKeyboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimulatorKeyboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPause;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer PauseTimer;
        private System.Windows.Forms.Timer StartTimer;
        private System.Windows.Forms.Timer StopTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.TextBox TbR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbYStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TbXStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TbEndY;
        private System.Windows.Forms.TextBox TbEndX;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}

