using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp4
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
            if (imageNum > imageList1.Images.Count) imageNum = 0;
            
            pictureBox1.Image = imageList1.Images[imageNum % imageList1.Images.Count];
            imageNum++;
        }
    }
}
