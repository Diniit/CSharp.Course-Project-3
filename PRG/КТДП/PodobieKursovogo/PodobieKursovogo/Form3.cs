using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodobieKursovogo
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void pb_exit_MouseMove(object sender, MouseEventArgs e)
        {
            pb_exit.Image = Properties.Resources.закрыть1 as Bitmap;
        }

        private void pb_exit_MouseLeave(object sender, EventArgs e)
        {
            pb_exit.Image = Properties.Resources.закрыть as Bitmap;
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void b_zhad_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
        }
    }
}
