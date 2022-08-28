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
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
        }

        private void ensaladasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void combosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void combo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo_principal cp = new combo_principal();
            cp.ShowDialog();
        }

        private void combo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo1 c1 = new combo1();
            c1.ShowDialog();
        }

        private void combo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo2 c2 = new combo2();
            c2.ShowDialog();
        }

        private void combo3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            combo3 c3 = new combo3();
            c3.ShowDialog();
        }

        private void combo4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combo4 c4 = new combo4();
            c4.ShowDialog();
        }

        private void sinExsitenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bocadillos bz = new Bocadillos();
            bz.ShowDialog();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            factura f = new factura();
            f.ShowDialog();
        }

        private void heladoToolStripMenuItem_Click(object sender, EventArgs e)
        {helados h1 = new helados();
            h1.ShowDialog();
        }

        private void pastelesToolStripMenuItem_Click(object sender, EventArgs e)
        {pasteles pp = new pasteles();
            pp.ShowDialog();
        }

        private void tartaletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tartaleta tt = new tartaleta();
            tt.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acercade aa = new acercade();
            aa.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
