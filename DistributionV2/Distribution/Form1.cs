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
using System.IO;
namespace Distribution
{
    public partial class Form1 : Form
    {
        public OpenFileDialog ofd = null;
        public string FileName = null;
        ArrayList data = null;
        double min;
        double max;
        double average;

        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
            minLabel.Visible = false;
            MaxLabel.Visible = false;
            AverageLabel.Visible = false;

            MintextBox.Visible = false;
            MaxtextBox.Visible = false;
            AveragetextBox.Visible = false;
            saveButton.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            //ofd.Filter = "TXT|txt|dat|dat | DAT | DAT";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.FileName;
                label1.Text = ofd.SafeFileName;
                button2.Visible = true;
            }
            else
            {
                label1.Text = "Choose File";
                button2.Visible = false;
                minLabel.Visible = false;
                MaxLabel.Visible = false;
                AverageLabel.Visible = false;

                MintextBox.Visible = false;
                MaxtextBox.Visible = false;
                AveragetextBox.Visible = false;
                saveButton.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data = new ArrayList();
            using (TextReader reader = File.OpenText(FileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    double d = Double.Parse(line);
                    data.Add(d);
                }
            }

            findMinMax(data);
            calcAverage(data);

            minLabel.Visible = true;
            MaxLabel.Visible = true;
            AverageLabel.Visible = true;

            MintextBox.Visible = true;
            MaxtextBox.Visible = true;
            AveragetextBox.Visible = true;

            MintextBox.Enabled = false;
            MaxtextBox.Enabled = false;
            AveragetextBox.Enabled = false;
            saveButton.Visible = true;

            MintextBox.Text = min.ToString();
            MaxtextBox.Text = max.ToString();
            AveragetextBox.Text = average.ToString();
        }


        public void   findMinMax(ArrayList data)
        {
            double mi = (double)data[0];
            double ma  = (double)data[0];;
            foreach (double m in data)
            {
                if ((double)m < mi)
                {
                    mi = m;
                }
            }

            foreach (double m in data)
            {
                if ((double)m > ma)
                {
                    ma = m;
                }
            }

            min = mi;
            max = ma;
        }

        public void calcAverage(ArrayList data)
        {
            double sum = 0.0;

            for (int i = 0; i < data.Count; i++)
            {
                sum += (double)data[i];
            }

            average = sum / data.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fName = ofd.FileName.Insert(ofd.FileName.IndexOf(".dat"), "Result");
        
                using (TextWriter writer = File.CreateText(fName))
                {
                    writer.WriteLine("{0}{1}", "Minimum: ", min);
                    writer.WriteLine("{0}{1}", "Maximum: ", max);
                    writer.WriteLine("{0}{1}", "Average: ", average);
                }
        }
        
    }
}
