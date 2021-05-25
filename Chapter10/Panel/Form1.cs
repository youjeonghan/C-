using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn1.Checked) MessageBox.Show("Red");
            else if (btn2.Checked) MessageBox.Show("Black");
            else if (btn3.Checked)
            {
                string name;
                name = other.Text;
                MessageBox.Show(name);
            }
        }
    }
}
