using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
 

        public Form1()
        {
            InitializeComponent();
            double d1 = 5e6;
            richTextBox1.AppendText(d1.ToString() + "\n");
            richTextBox1.AppendText(d1.ToString("N") + "n");
            richTextBox1.AppendText(d1.ToString("N3") + "\n");
            richTextBox1.AppendText(d1.ToString("N0") + "\n");
            richTextBox1.AppendText(d1.ToString("0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0E0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.00e00") + "\n");
            double Pi = 3.141592653589793;
            double c = 299792458;
            richTextBox1.AppendText(d1.ToString("N3") + "\n");
            richTextBox1.AppendText(d1.ToString("N5") + "\n");
            richTextBox1.AppendText(d1.ToString("n15") + "\n");
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
