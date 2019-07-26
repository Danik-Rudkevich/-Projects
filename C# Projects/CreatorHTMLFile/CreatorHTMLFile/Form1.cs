using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatorHTMLFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            //Directory.CreateDirectory(richTextBox1.Text);

            DirectoryInfo di = Directory.CreateDirectory(richTextBox1.Text);

            File.Copy(@"Shablon\index.html",richTextBox1.Text+"/"+ "index.html");
            File.Copy(@"Shablon\script.js", richTextBox1.Text + "/" + "script.js");
            File.Copy(@"Shablon\my-grid.css", richTextBox1.Text + "/" + "my-grid.css");
            File.Copy(@"Shablon\style.css", richTextBox1.Text + "/" + "style.css");
        }
    }
}
