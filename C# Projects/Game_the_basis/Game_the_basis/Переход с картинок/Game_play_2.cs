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
    public partial class Game_play_2 : Form
    {
        public Game_play_2()
        {
            InitializeComponent();
        }

        int a, b;
        Random rnd = new Random();

        private void Game_play_2_Load(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            a = rnd.Next(1, 20);
            b = a;
            a = a * a;
            

            lbl1.Text = "Корень " + Convert.ToString(a) + " = ";
        }

        private void tb1_TextChanged_1(object sender, EventArgs e)
        {
            if (tb1.Text == Convert.ToString(b))
            {
                tb2.Text = "yes";
                this.Close();
            }
        }

    }
}
