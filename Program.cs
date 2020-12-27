using System;
using System.Windows.Forms;

namespace Программный_комплекс_конвертер_валют_MySQL
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
            Application.Run(new KonvForm());
        }
    }
}
