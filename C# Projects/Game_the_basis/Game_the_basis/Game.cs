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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void pb_1_Click(object sender, EventArgs e)
        {
            Game_play_1 game_play_1 = new Game_play_1();
            this.Hide();
            game_play_1.ShowDialog();
            if (game_play_1.tb2.Text =="yes") 
            {
                pb_1.Visible = false;
            }
            this.Show();
        }

        private void pb_3_Click(object sender, EventArgs e)
        {
            Game_play_1 game_play_1 = new Game_play_1();
            this.Hide();
            game_play_1.ShowDialog();
            if (game_play_1.tb2.Text == "yes")
            {
                pb_3.Visible = false;
            }
            this.Show();
        }

        private void pb_2_Click(object sender, EventArgs e)
        {
            Game_play_1 game_play_1 = new Game_play_1();
            this.Hide();
            game_play_1.ShowDialog();
            if (game_play_1.tb2.Text == "yes")
            {
                pb_2.Visible = false;
            }
            this.Show();
        }

        private void pb_4_Click(object sender, EventArgs e)
        {
            Game_play_1 game_play_1 = new Game_play_1();
            this.Hide();
            game_play_1.ShowDialog();
            if (game_play_1.tb2.Text == "yes")
            {
                pb_4.Visible = false;
            }
            this.Show();
        }

        private void pb_5_Click(object sender, EventArgs e)
        {
            Game_play_1 game_play_1 = new Game_play_1();
            this.Hide();
            game_play_1.ShowDialog();
            if (game_play_1.tb2.Text == "yes")
            {
                pb_5.Visible = false;
            }
            this.Show();
        }

        private void pb_6_Click(object sender, EventArgs e)
        {
            Game_play_1 game_play_1 = new Game_play_1();
            this.Hide();
            game_play_1.ShowDialog();
            if (game_play_1.tb2.Text == "yes")
            {
                pb_6.Visible = false;
            }
            this.Show();
        }

        private void pb_7_Click(object sender, EventArgs e)
        {
            Game_play_1 game_play_1 = new Game_play_1();
            this.Hide();
            game_play_1.ShowDialog();
            if (game_play_1.tb2.Text == "yes")
            {
                pb_7.Visible = false;
            }
            this.Show();
        }

        private void pb_8_Click(object sender, EventArgs e)
        {
            Game_play_1 game_play_1 = new Game_play_1();
            this.Hide();
            game_play_1.ShowDialog();
            if (game_play_1.tb2.Text == "yes")
            {
                pb_8.Visible = false;
            }
            this.Show();
        }

        private void pb_9_Click(object sender, EventArgs e)
        {
            Game_play_1 game_play_1 = new Game_play_1();
            this.Hide();
            game_play_1.ShowDialog();
            if (game_play_1.tb2.Text == "yes")
            {
                pb_9.Visible = false;
            }
            this.Show();
        }
    }
}
