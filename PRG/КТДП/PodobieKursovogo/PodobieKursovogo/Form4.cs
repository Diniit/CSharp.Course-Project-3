using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace PodobieKursovogo
{
    public partial class MessageBox : Form
    {

        public MessageBox()
        {
            InitializeComponent();
            /*
             * PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("franklin.ttf"); // файл шрифта
            FontFamily f = fontCollection.Families[0];
            l_mes1.Font = new Font(f, 10, FontStyle.Bold);
            l_mes2.Font = new Font(f, 10, FontStyle.Bold);
            l_mes3.Font = new Font(f, 10, FontStyle.Bold);
            */
        }
        private void l_ok_MouseMove(object sender, MouseEventArgs e)
        {
            l_ok.ForeColor = Color.FromArgb(64,64,64);
        }
        private void l_ok_MouseLeave(object sender, EventArgs e)
        {
            l_ok.ForeColor = Color.White;
        }

        private void l_ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
