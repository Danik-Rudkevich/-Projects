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
    public partial class frmGlavn : Form
    {
        public frmGlavn()
        {
            InitializeComponent();
        }

        private void pb_1_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            this.Hide();
            game.BackgroundImage = Properties.Resources._1;
            game.ShowDialog();
            this.Show();
        }

        private void pb_2_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            this.Hide();
            game.BackgroundImage = Properties.Resources._2;
            game.ShowDialog();
            this.Show();
        }

        private void pb_9_Click(object sender, EventArgs e)
        {
            Game3 game = new Game3();
            this.Hide();
            game.BackgroundImage = Properties.Resources._9;
            game.ShowDialog();
            this.Show();
        }

        private void pb_3_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            this.Hide();
            game.BackgroundImage = Properties.Resources._3;
            game.ShowDialog();
            this.Show();
        }

        private void pb_4_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            this.Hide();
            game.BackgroundImage = Properties.Resources._4;
            game.ShowDialog();
            this.Show();
        }

        private void pb_5_Click(object sender, EventArgs e)
        {
            Game_2 game = new Game_2();
            this.Hide();
            game.BackgroundImage = Properties.Resources._5;
            game.ShowDialog();
            this.Show();
        }

        private void pb_8_Click(object sender, EventArgs e)
        {
            Game3 game = new Game3();
            this.Hide();
            game.BackgroundImage = Properties.Resources._8;
            game.ShowDialog();
            this.Show();
        }

        private void pb_7_Click(object sender, EventArgs e)
        {
            Game_2 game = new Game_2();
            this.Hide();
            game.BackgroundImage = Properties.Resources._7;
            game.ShowDialog();
            this.Show();
        }

        private void pb_6_Click(object sender, EventArgs e)
        {
            Game_2 game = new Game_2();
            this.Hide();
            game.BackgroundImage = Properties.Resources._6;
            game.ShowDialog();
            this.Show();
        }

       
    }
}
