using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open file dialog to read file 
            OpenFileDialog TestDialog = new OpenFileDialog();
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (TestDialog.ShowDialog() == DialogResult.OK)
            { 
                //load picture to picture box 
                pictureBox1.ImageLocation = TestDialog.FileName;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
