namespace GeneratorSQL
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbTown = new System.Windows.Forms.TextBox();
            this.TbOS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RTBOutput = new System.Windows.Forms.RichTextBox();
            this.BtnGenerator = new System.Windows.Forms.Button();
            this.TbKol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название таблицы:";
            // 
            // TbTableName
            // 
            this.TbTableName.Location = new System.Drawing.Point(126, 13);
            this.TbTableName.Name = "TbTableName";
            this.TbTableName.Size = new System.Drawing.Size(194, 20);
            this.TbTableName.TabIndex = 1;
            this.TbTableName.Text = "RudTable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Названия городов:";
            // 
            // TbTown
            // 
            this.TbTown.Location = new System.Drawing.Point(126, 56);
            this.TbTown.Name = "TbTown";
            this.TbTown.Size = new System.Drawing.Size(916, 20);
            this.TbTown.TabIndex = 3;
            this.TbTown.Text = "Минск Гродно Брест Гомель Могилёв";
            // 
            // TbOS
            // 
            this.TbOS.Location = new System.Drawing.Point(126, 101);
            this.TbOS.Name = "TbOS";
            this.TbOS.Size = new System.Drawing.Size(916, 20);
            this.TbOS.TabIndex = 5;
            this.TbOS.Text = "Mac Windows Linux";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Названия ОС:";
            // 
            // RTBOutput
            // 
            this.RTBOutput.Location = new System.Drawing.Point(16, 132);
            this.RTBOutput.Name = "RTBOutput";
            this.RTBOutput.Size = new System.Drawing.Size(1026, 279);
            this.RTBOutput.TabIndex = 6;
            this.RTBOutput.Text = "";
            this.RTBOutput.DoubleClick += new System.EventHandler(this.RTBOutput_DoubleClick);
            // 
            // BtnGenerator
            // 
            this.BtnGenerator.Location = new System.Drawing.Point(526, 13);
            this.BtnGenerator.Name = "BtnGenerator";
            this.BtnGenerator.Size = new System.Drawing.Size(516, 23);
            this.BtnGenerator.TabIndex = 7;
            this.BtnGenerator.Text = "Генерация ";
            this.BtnGenerator.UseVisualStyleBackColor = true;
            this.BtnGenerator.Click += new System.EventHandler(this.BtnGenerator_Click);
            // 
            // TbKol
            // 
            this.TbKol.Location = new System.Drawing.Point(420, 13);
            this.TbKol.Name = "TbKol";
            this.TbKol.Size = new System.Drawing.Size(100, 20);
            this.TbKol.TabIndex = 9;
            this.TbKol.Text = "30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кол-во вставок:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 423);
            this.Controls.Add(this.TbKol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGenerator);
            this.Controls.Add(this.RTBOutput);
            this.Controls.Add(this.TbOS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbTown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbTableName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbTown;
        private System.Windows.Forms.TextBox TbOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RTBOutput;
        private System.Windows.Forms.Button BtnGenerator;
        private System.Windows.Forms.TextBox TbKol;
        private System.Windows.Forms.Label label4;
    }
}

