using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace scm
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static Form1 form;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form = new Form1());
        }
    }
}
