using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace BackUper
{
    public partial class Glavn : Form
    {
        public Glavn()
        {
            InitializeComponent();
        }

        int Rise = 0;

        private int checkFileKol(string Folder)//узнаем кол-во файлов 
        {
            int kol = 0;

            DirectoryInfo dirInfo = new DirectoryInfo(Folder);//Получаем все что лежит в папке from

            foreach (DirectoryInfo dir in dirInfo.GetDirectories()) //Дублируем папки , а потом заполняем их
            {
                if (dir.Name == "BackUp")//Это условие сделано специально под задачу.Его можно убрать
                {
                    continue;
                }
                kol = checkFileKol(Folder + "/" + dir.Name);
            }

            return kol + dirInfo.GetFiles().Length;
        }

        private void dirCopy(string from,string to) //Функция для копирования папок со всем содержимым
        {
            DirectoryInfo dirInfo = new DirectoryInfo(from);//Получаем все что лежит в папке from

            foreach (FileInfo fl in dirInfo.GetFiles()) //Переносим файлы
            {
                fl.CopyTo(to+ "\\"+fl.Name, true);

                AddLog("Файл "+ fl.Name + " перенесен");//Вывод логов.Удаляем

                if(pbProgress.Value + Rise <= 100)//Иногда выходит за пределы value.Исправляю
                {
                    pbProgress.Value += Rise;//Прирост от кол-во файлов
                }  
            }

            foreach (DirectoryInfo dir in dirInfo.GetDirectories()) //Дублируем папки , а потом заполняем их
            {
                if(dir.Name == "BackUp")//Это условие сделано специально под задачу.Его можно убрать
                {
                    continue;
                }
                Directory.CreateDirectory(to + "/" + dir.Name);//Создаем пустую папку
                AddLog("Папка " + dir.Name + " создана");//Вывод логов.Удаляем
                dirCopy(from+"/"+ dir.Name, to + "/" + dir.Name);//Заходим в оригинальную папку и выкачиваем её содержимое в дубликат
            }
        }

        private void AddLog(string log)
        {
            rtbLog.Text += "\n\n" + log;
        }

        private void pbFast_Click(object sender, EventArgs e)
        {
            pbProgress.Value = 0;

            pbProgress.Visible = true;

            AddLog("Быстрый BackUp Start");

            string date = DateTime.Now.ToLongDateString() + "(" + DateTime.Now.ToLongTimeString() + ")";

            date = date.Replace(':', '-');
            date = date.Replace('.', ' ');

            Directory.CreateDirectory("BackUp/" + date);

            AddLog("Папка BackUp/" + date + " Создана");

            string rizone = "";

            using (BackUp_Info form2 = new BackUp_Info())
            {
                this.Hide();

                DialogResult dr = form2.ShowDialog();

                if (dr == DialogResult.Cancel)
                {
                    rizone = form2.Returner;
                }
            }

            this.Show();

           
            if(rizone!="")
            {
                File.AppendAllText("BackUp/" + date + "\\BackUp-Info.txt", rizone);
                AddLog("Файл с комментарием к BackUp создан");
            }
            else
            {
                File.AppendAllText("BackUp/" + date + "\\BackUp-Info.txt", @"BackUp без причины ¯\_(ツ)_/¯");
                AddLog("Файл без комментария к BackUp создан");
            }
            
            string fullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            Rise = checkFileKol(fullPath);

            DialogResult drmb = MessageBox.Show("Кол-во файлов = "+Rise.ToString()+"\n\nСделать BackUp?","BackUp", MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);

            if(drmb != DialogResult.Yes)
            {
                pbProgress.Visible = false;
                AddLog("BackUp отменен!\n_______________________________________________________________________\n");
                return;
            }

            dirCopy(fullPath, "BackUp/" + date);

            pbProgress.Value = 100;

            pbProgress.Visible = false;

            AddLog("Быстрый BackUp завершен!\n_______________________________________________________________________\n");

            //string exeName = Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location); //Узнаем название exe


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string dirTo="", dirFor="";

            MessageBox.Show("Выберите папку которую нужно сохранить");

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dirTo = fbd.SelectedPath;
                }
            }

            MessageBox.Show("Выберите папку в которую нужно сохранить BackUp");

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dirFor = fbd.SelectedPath;
                }
            }

            pbProgress.Value = 0;

            pbProgress.Visible = true;

            AddLog("BackUp из\n\n"+ dirTo + "\n\nв\n\n"+ dirFor);

            string date = DateTime.Now.ToLongDateString() + "(" + DateTime.Now.ToLongTimeString() + ")";

            date = date.Replace(':', '-');
            date = date.Replace('.', ' ');

            Directory.CreateDirectory(dirFor + "/BackUp/" + date);

            AddLog("Папка BackUp/" + date + " Создана");

            string rizone = "";

            using (BackUp_Info form2 = new BackUp_Info())
            {
                this.Hide();

                DialogResult dr = form2.ShowDialog();

                if (dr == DialogResult.Cancel)
                {
                    rizone = form2.Returner;
                }
            }

            this.Show();


            if (rizone != "")
            {
                File.AppendAllText(dirFor + "/BackUp/" + date + "\\BackUp-Info.txt", rizone);
                AddLog("Файл с комментарием к BackUp создан");
            }
            else
            {
                File.AppendAllText(dirFor + "/BackUp/" + date + "\\BackUp-Info.txt", @"BackUp без причины ¯\_(ツ)_/¯");
                AddLog("Файл без комментария к BackUp создан");
            }

            string fullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            Rise = checkFileKol(dirTo);

            DialogResult drmb = MessageBox.Show("Кол-во файлов = " + Rise.ToString() + "\n\nСделать BackUp?", "BackUp", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (drmb != DialogResult.Yes)
            {
                pbProgress.Visible = false;
                AddLog("BackUp отменен!\n_______________________________________________________________________\n");
                return;
            }

            dirCopy(dirTo, dirFor + "/BackUp/" + date);

            pbProgress.Value = 100;

            pbProgress.Visible = false;

            AddLog("BackUp завершен!\n_______________________________________________________________________\n");

            //string exeName = Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location); //Узнаем название exe

        }
    }
}
