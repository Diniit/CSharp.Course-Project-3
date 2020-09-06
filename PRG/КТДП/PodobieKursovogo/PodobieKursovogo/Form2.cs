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
    public partial class fAvtor : Form
    {
        public fAvtor()
        {
            InitializeComponent();
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pb_exit_MouseMove(object sender, MouseEventArgs e)
        {
            pb_exit.Image = Properties.Resources.закрыть as Bitmap;
        }

        private void pb_exit_MouseLeave(object sender, EventArgs e)
        {
            pb_exit.Image = Properties.Resources.закрыть1 as Bitmap;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.DimGray;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(64, 64, 64);
        }
    }
}
