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
    public partial class Game_play_1 : Form
    {
        public Game_play_1()
        {
            InitializeComponent();
        }

        int a, b, c;
        Random rnd = new Random();

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if (tb1.Text == Convert.ToString(c))
            {
                tb2.Text = "yes";
                this.Close();
            }
        }

        private void Game_play_1_Load(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            a = rnd.Next(1,9);
            b = rnd.Next(1, 9);
            c = a * b;

            lbl1.Text = Convert.ToString(a) + " * " + Convert.ToString(b) + " = ";


        }
    }
}
