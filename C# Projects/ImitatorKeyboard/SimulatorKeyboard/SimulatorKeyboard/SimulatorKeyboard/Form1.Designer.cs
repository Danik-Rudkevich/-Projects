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
            this.label3 = new System.Windows.Forms.Label();
            this.tbPause = new System.Windows.Forms.TextBox();
            this.tbWork = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PauseTimer = new System.Windows.Forms.Timer(this.components);
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.StopTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клавиши:";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(68, 11);
            this.tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(182, 20);
            this.tb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Задержка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Время работы:";
            // 
            // tbPause
            // 
            this.tbPause.Location = new System.Drawing.Point(73, 40);
            this.tbPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPause.Name = "tbPause";
            this.tbPause.Size = new System.Drawing.Size(178, 20);
            this.tbPause.TabIndex = 4;
            this.tbPause.Text = "0";
            // 
            // tbWork
            // 
            this.tbWork.Location = new System.Drawing.Point(95, 67);
            this.tbWork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbWork.Name = "tbWork";
            this.tbWork.Size = new System.Drawing.Size(156, 20);
            this.tbWork.TabIndex = 5;
            this.tbWork.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SimulatorKeyboard.Properties.Resources.start_button;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(254, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label4.Location = new System.Drawing.Point(10, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Скорость работы:";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(110, 93);
            this.tbSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(141, 20);
            this.tbSpeed.TabIndex = 8;
            this.tbSpeed.Text = "1000";
            // 
            // SimulatorKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 120);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbWork);
            this.Controls.Add(this.tbPause);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "SimulatorKeyboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimulatorKeyboard";
            this.Load += new System.EventHandler(this.SimulatorKeyboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPause;
        private System.Windows.Forms.TextBox tbWork;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer PauseTimer;
        private System.Windows.Forms.Timer StartTimer;
        private System.Windows.Forms.Timer StopTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSpeed;
    }
}

