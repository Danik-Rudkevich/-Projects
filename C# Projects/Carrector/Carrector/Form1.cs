using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Carrector
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        public void chooseDir()
        {
            string dirTo = "", dirFor = ""; // Пути для папок

            if(MessageBox.Show("Выберите папку файлы которой нужно перенести", "From", MessageBoxButtons.OKCancel) == DialogResult.Cancel) // Если отмена
            {
                return;//Выход
            }

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dirTo = fbd.SelectedPath; 
                }
                else
                {
                    return;//Выход
                }
            }

            if (MessageBox.Show("Выберите папку в которую нужно перенести файлы", "To", MessageBoxButtons.OKCancel) == DialogResult.Cancel)// Если отмена
            {
                return;//Выход
            }

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dirFor = fbd.SelectedPath;
                }
                else
                {
                    return;//Выход
                }
            }

            if (MessageBox.Show("Подтвердите перенос файлов из:\n"+ dirTo + "\nВ папку \n"+dirFor, "Path check", MessageBoxButtons.YesNo) == DialogResult.No )// Если отмена
            {
                return;//Выход
            }

            Progress progress = new Progress(dirFor, dirTo);
            this.Hide();
            progress.ShowDialog();
            this.Show();
        }

        private void pbStart_Click(object sender, EventArgs e)
        {
            chooseDir();

            //DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
            //if (result == DialogResult.Yes)
            //{
            //    //...
            //}
            
        }
    }
}
