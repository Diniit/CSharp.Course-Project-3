using System;
using System.Windows.Forms;

namespace PodobieKursovogo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Trenazher());
        }
    }
}
