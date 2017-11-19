using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private double x;
        private double y;
        private double result;

        public Form1()
        {
            InitializeComponent();
        }

        public void readData()
        {
            x = Double.Parse(textBox1.Text);
            y = Double.Parse(textBox2.Text);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readData();
            result = x + y;
            label1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readData();
            result = x - y;
            label1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            readData();
            result = x * y;
            label1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            readData();
            result = x / y;
            label1.Text = result.ToString();
        }
    }
}
