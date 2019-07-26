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
    public partial class Who : Form
    {
        public Who()
        {
            InitializeComponent();
        }

        private void Who_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Who_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Escape) return; //Интересный код
            {
                this.Close();
            }
        }
    }
}
