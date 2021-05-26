using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class parentForm : Form
    {
        public parentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm1 child = new childForm1();
            child.MdiParent = this;
            child.Show();
        }

        private void javaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm2 child = new childForm2();
            child.MdiParent = this;
            child.Show();
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm3 child = new childForm3();
            child.MdiParent = this;
            child.Show();
        }

        private void cascadedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void arrangeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
