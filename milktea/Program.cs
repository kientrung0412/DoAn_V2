using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milktea
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
//            lựa trọn form nào chạy đầu tiên
//            Application.Run(new demoTable());
            Application.Run(new frmMain());
//            Application.Run(new Main());
        }
    }
}