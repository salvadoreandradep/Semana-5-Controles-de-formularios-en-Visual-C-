using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_5_y_6
{
    public partial class combo_principal : Form
    {
        public combo_principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            combo1 c1 = new combo1();
            c1.ShowDialog();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            combo3 c3 = new combo3();
            c3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            combo2 c2 = new combo2();
            c2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            combo4 c4 = new combo4();
            c4.ShowDialog();
        }
    }
}
