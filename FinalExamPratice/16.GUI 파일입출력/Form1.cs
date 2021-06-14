using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _16.GUI_파일입출력
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Dev\Github\C_sharp_progaming\test.txt");
            file.WriteLine(textBox1.Text);
            file.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog temp = new OpenFileDialog();
            temp.Filter = "Text file|*.txt";
            if (temp.ShowDialog() == DialogResult.OK)
            {
                var fileStream = temp.OpenFile();
                StreamReader reader = new StreamReader(fileStream);
                textBox2.Text = reader.ReadToEnd();
                reader.Close();
            }
            
        }
    }
}
