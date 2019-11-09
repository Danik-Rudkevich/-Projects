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
using MetroFramework.Forms;

namespace Carrector
{
    public partial class Progress : MetroForm
    {
        string dirTo, dirFrom;

        public Progress(string to, string from)
        {
            InitializeComponent();
            dirTo = to;
            dirFrom = from;
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            rtbOutput.Text = "Start\n\n";
            dirCopy(dirFrom, dirTo);
            rtbOutput.Text += "\n\nComplete\n";
        }

        private void dirCopy(string from, string to) //Функция для копирования папок со всем содержимым
        {
            DirectoryInfo dirInfo = new DirectoryInfo(from);//Получаем все что лежит в папке from

            foreach (FileInfo fl in dirInfo.GetFiles()) //Переносим файлы
            {
                rtbOutput.Text += "\nПереносим файл " + fl.Name;
                fl.CopyTo(to + "\\" + fl.Name, true);
            }

            foreach (DirectoryInfo dir in dirInfo.GetDirectories()) //Проходимся по папкам а потом заполняем их
            {
                dirCopy(from + "\\" + dir.Name, to);//Заходим в оригинальную папку и выкачиваем её содержимое в to
            }
        }

    }
}
