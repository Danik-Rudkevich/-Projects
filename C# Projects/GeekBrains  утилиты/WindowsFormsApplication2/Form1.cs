using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class program : Form
    {

        int count = 0;
        Random rnd;
        char[] spec_chars = new char[] {'%','*','!','?','&','(','#'};
        Dictionary<string, double> metrica;


        public program()
        {
            InitializeComponent();
            rnd = new Random();
            metrica = new Dictionary<string, double>();
            metrica.Add("mm",1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000000);
            metrica.Add("mile", 1609344);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count=0;
            lblCount.Text = Convert.ToString(count);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
            lblRandom.Text = n.ToString();
            if (cbRandom.Checked)
            {
               if (tbRandom.Text.IndexOf(n.ToString()) == -1) tbRandom.AppendText(n + "\n"); // Поик в тексте возврат -1
            }
            else tbRandom.AppendText(n + "\n");
        }

        

        private void btmRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btmRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
          rtbNotepad.AppendText(DateTime.Now.ToLongDateString()+"\n");
        }

        private void tsmiInsertTime_Click(object sender, EventArgs e)
        {
          rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void вставитьДатуИВремяToolStripMenuItem_Click(object sender, EventArgs e)
        {
          rtbNotepad.AppendText(DateTime.Now.ToLongDateString() + "\n");
          rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void блокнотToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiClear_Click(object sender, EventArgs e)
        {
            rtbNotepad.Clear();
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
               rtbNotepad.SaveFile("notepad.doc");
            }
            catch
            {
               MessageBox.Show("Что-то с сохранением!!!");
            }


        }

        
        

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Что-то с Загрузкой!!!");
            }
        }

        private void program_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCreatePassword_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;
            string password = "";
            for(int i = 0; i < nudPassword.Value; ++i)
            {
              int n = rnd.Next(0,clbPassword.CheckedItems.Count);
                string s = clbPassword.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры": password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы": password += Convert.ToChar(rnd.Next(65,88));
                        break;
                    case "Строчные буквы": password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += spec_chars[rnd.Next(spec_chars.Length)];
                        break;
                }
                tbWritePassword.Text = password;
                Clipboard.SetText(password);
            }
        }

        private void clbPassword_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cbFrom.Text];
            double m2 = metrica[cbTo.Text];
            double n = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (n * m1 / m2).ToString();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string t = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = t;
        }

        private void cbMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetric.Text)
            {
                case"Длина":
            metrica.Clear();
            metrica.Add("mm",1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000000);
            metrica.Add("mile", 1609344);
            cbFrom.Items.Clear();
                    cbFrom.Items.Add("mm");
                    cbFrom.Items.Add("cm");
                    cbFrom.Items.Add("dm");
                    cbFrom.Items.Add("m");
                    cbFrom.Items.Add("km");
                    cbFrom.Items.Add("mile");
            cbTo.Items.Clear();
                    cbTo.Items.Add("mm");
                    cbTo.Items.Add("cm");
                    cbTo.Items.Add("dm");
                    cbTo.Items.Add("m");
                    cbTo.Items.Add("km");
                    cbTo.Items.Add("mile");
                    cbFrom.Text="mm";
                    cbTo.Text="mm";

                    break;

                case"Вес":
            metrica.Clear();
            metrica.Add("g",1);
            metrica.Add("kg", 1000);
            metrica.Add("lb", 453.6);
            metrica.Add("t", 1000000);
            cbFrom.Items.Clear();
                    cbFrom.Items.Add("g");
                    cbFrom.Items.Add("kg");
                    cbFrom.Items.Add("lb");
                    cbFrom.Items.Add("t");
            cbTo.Items.Clear();
                    cbTo.Items.Add("g");
                    cbTo.Items.Add("kg");
                    cbTo.Items.Add("lb");
                    cbTo.Items.Add("t");
                    cbFrom.Text="g";
                    cbTo.Text="g";

                    break;
                default:
                    break;
            }
        }

        private void rtbNotepad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbRandom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbRandom_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

       
    }
}
