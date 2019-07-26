using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_the_basis
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            intro intro = new intro();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(3);
            intro.Show();
            while(end > DateTime.Now)
            {
                Application.DoEvents();
            }
            intro.Close();
            intro.Dispose();

            Application.Run(new frmpreglavn());
        }
    }
}
