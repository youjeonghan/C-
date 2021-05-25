using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groupbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn1.Checked) MessageBox.Show("Male Selected");
            if (btn2.Checked) MessageBox.Show("Female selected");
            if (btn3.Checked) MessageBox.Show("LG Telecome");
            if (btn4.Checked) MessageBox.Show("KT Telecome");
        }
    }
}
