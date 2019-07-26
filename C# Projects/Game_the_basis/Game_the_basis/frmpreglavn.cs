using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_the_basis
{
    public partial class frmpreglavn : Form
    {
        public frmpreglavn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_start_Click(object sender, EventArgs e)
        {
            frmGlavn frmglavn = new frmGlavn();
            this.Hide();
            frmglavn.ShowDialog();
            this.Show();
        }

        private void pb_who_Click(object sender, EventArgs e)
        {
            Who who = new Who();
            this.Hide();
            who.ShowDialog();
            this.Show();
        }
    }
}
