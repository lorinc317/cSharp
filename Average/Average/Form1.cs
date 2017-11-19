using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.IO;
namespace Average
{
    public partial class Form1 : Form
    {
        Data d;
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d = new Data();
            d.readData();
            d.findMin();
            d.findMax();
            d.calcAverage();

            

            textBox1.Text = d.min.ToString();
            textBox2.Text = d.max.ToString();
            textBox3.Text = d.average.ToString();
        }
    }

    class Data {
        public ArrayList dat = null;
        public string fileName;
        public double min;
        public double max;
        public double average;
        public Data()
        {
            dat = new ArrayList();
            fileName = "data.txt";
        }

        public void readData()
        {
            using (TextReader reader = File.OpenText(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    dat.Add(Double.Parse(line));
                }
            }
        }

        public void findMin()
        {
            int i;
            min = (Double)dat[0];
            for (i = 1; i < dat.Count; i++)
            {
                if ((double)dat[i] < min)
                {
                    min = (Double)dat[i];
                }
            }
        }

        public void findMax()
        {
            int i;
            max = (Double)dat[0];
            for (i = 1; i < dat.Count; i++)
            {
                if ((double)dat[i] > max)
                {
                    max = (Double)dat[i];
                }
            }
        }

        public void calcAverage()
        {
            int i;
            double sum = 0;
            for (i = 0; i < dat.Count; i++)
            {
                sum += (Double)dat[i];
            }

            average = sum / (double)dat.Count;
        }

    }
}
