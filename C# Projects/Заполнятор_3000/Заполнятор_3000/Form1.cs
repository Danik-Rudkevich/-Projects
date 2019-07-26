using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace Заполнятор_3000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var sum = tb_sum_nomber.Text;
            var sum_b = tb_sum_bukv.Text;
            var name = tb_name.Text;
            var adres = tb_adres.Text;
            string date = DateTime.Now.ToLongDateString();
            string file = "Original.docx";
            string papk = date;
            string zak = "zakaz_";
            int nomer;

            if (Directory.Exists(date) == false)
            {
                Directory.CreateDirectory(date);
                // textBox5.Text = Convert.ToString(Path.GetFullPath(file));
                //  textBox6.Text = Convert.ToString(Path.GetFullPath(papk));
                richTextBox1.Text = "1";
                richTextBox1.SaveFile("number.doc");

            }

            if (Directory.Exists(date) == true)
            {
                textBox1.Text = Convert.ToString(Path.GetFullPath(file));
                textBox2.Text = Convert.ToString(Path.GetFullPath(papk));
              
                try
                {
                    
                    var wordApp = new Word.Application();
                    wordApp.Visible = false;

                    richTextBox1.LoadFile("number.doc");
                    nomer = Convert.ToInt32(richTextBox1.Text);



                    var wordDocument = wordApp.Documents.Open(textBox1.Text);

                    ReplaceWordStub("{name}", name, wordDocument);
                    ReplaceWordStub("{sum}", sum, wordDocument);
                    ReplaceWordStub("{sum_b}", sum_b, wordDocument);
                    ReplaceWordStub("{adres}", adres, wordDocument);
                    ReplaceWordStub("{sum}", sum, wordDocument);
                    ReplaceWordStub("{sum_b}", sum_b, wordDocument);
                    ReplaceWordStub("{name}", name, wordDocument);
                    ReplaceWordStub("{adres}", adres, wordDocument);

                    string put1 = @"\zakaz_" + nomer + ".docx";

                    textBox3.Text = Convert.ToString(Path.GetFullPath(textBox2.Text + put1));

                    wordDocument.SaveAs(textBox3.Text);

                    nomer += 1;

                    richTextBox1.Text = Convert.ToString(nomer);

                    richTextBox1.SaveFile("number.doc");

                    
                    wordApp.Visible = true;
                    //wordDocument.Close();
                    //wordApp.Quit();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            } 
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {

            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
        
    }
}
