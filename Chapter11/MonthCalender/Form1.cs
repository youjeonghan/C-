using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //display the selected date on the label 
            label1.Text = dateTimePicker1.Value.ToLongDateString();
            //label1.Text = dateTimePicker1.Value.ToString("MM-dd-yyyy");
        }
    }
}
