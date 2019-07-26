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
    public partial class Game_play_3 : Form
    {
        public Game_play_3()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int a, b, c , d , sum;

       

        private void Game_play_3_Load(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            a = rnd.Next(1, 15);
            b = rnd.Next(1, 15);
            d = rnd.Next(1, 30);
            c = rnd.Next(1,2);

            if (c == 1)
            {
                sum = a * b + d;
                lbl1.Text = Convert.ToString(a) + " * " + Convert.ToString(b) + " + " + Convert.ToString(d) + " = ";
            }
            if (c == 2)
            {
                sum = a * b - d;
                lbl1.Text = Convert.ToString(a) + " * " + Convert.ToString(b) + " - " + Convert.ToString(d) + " = ";
            }

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if (tb1.Text == Convert.ToString(sum))
            {
                tb2.Text = "yes";
                this.Close();
            }
        }
    }
}
