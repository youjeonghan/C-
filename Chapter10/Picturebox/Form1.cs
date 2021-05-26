using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int imageNum = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[imageNum% imageList1.Images.Count];
            imageNum ++;
        }
    }
}
