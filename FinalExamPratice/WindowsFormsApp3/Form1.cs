using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private MessageBoxIcon IconType { get; set; }
        private MessageBoxButtons ButtonType { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp="";
            if (radioButton1.Checked)
            {
                temp = "그는 ";
            }
            if (radioButton2.Checked)
            {
                temp = "그녀는 ";
            }


            if (checkBox1.Checked)
            {
                temp = temp + "비비큐 ";
            }
            if (checkBox2.Checked)
            {
                temp = temp + "네네치킨";
            }
            if (checkBox1.Checked==true || checkBox2.Checked == true)
            {
                temp = temp + "을 좋아합니다.";
            }
            else
            {
                temp = temp + "치킨을 좋아하지않습니다.";
            }

            label1.Text = temp;
            
        }
    }
}
