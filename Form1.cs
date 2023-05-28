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

namespace FRDO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string str = File.ReadAllText(filename);

            str = str.Replace(Environment.NewLine, " ");

            char[] delimiterChars = { ' ', '\n' };


            string[] mystring = str.Split(delimiterChars);
       
            for(int i = 0; i < mystring.Length; i = i + 3)
            {
                richTextBox1.Text += Convert.ToString(mystring[i]);
                richTextBox1.Text += Environment.NewLine;

            }

            for (int i = 1; i < mystring.Length; i = i + 3)
            {
                richTextBox2.Text += Convert.ToString(mystring[i]);
                richTextBox2.Text += Environment.NewLine;

            }

            for (int i = 2; i < mystring.Length; i = i + 3)
            {
                richTextBox3.Text += Convert.ToString(mystring[i]);
                richTextBox3.Text += Environment.NewLine;

            }

        }
    }
}
