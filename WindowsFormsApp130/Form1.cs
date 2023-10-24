using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp130
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] s = new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text };
            System.Windows.Forms.OpenFileDialog op = new OpenFileDialog();
            op.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";
            op.ShowDialog();
            System.IO.StreamWriter w = new System.IO.StreamWriter(op.FileName,true);
            w.WriteLine(string.Join(";", s));
            w.Close();

        }
    }
}
