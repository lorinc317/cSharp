using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sine_Wave
{
    public partial class Form1 : Form
    {
        public Graphics g;
        Color[] col = { Color.Black, Color.Red, Color.Green, Color.Blue};
        int xAxOffset = 0;
        int heightofX = 0;
        int widthofY = 0;
        int yAxOffset = 0;
        public double a=1, f = 1, phase = 0;
        Pen p;
        public Form1()
        {
            InitializeComponent();
            
            this.Shown += new System.EventHandler(this.OnLoaded);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_Click);
            button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_Click);
            panel1.BackColor = Color.Gray;
            //comboBox1.SelectedIndex = 0;
            heightofX = panel1.Height / 2;
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Up))
            {
                heightofX += 2;
                draw();
                this.Focus();
            }
        }

        public void DrawAxis(Graphics g, Point s, Point e )
        {
            Pen blackPen = new Pen(Color.Black, 1);
            
            g.DrawLine(blackPen, s, e);
        }
        
        private void OnLoaded(object sender, EventArgs e)
        {
            
            g = panel1.CreateGraphics();
            DrawAxis(g, new Point(xAxOffset, heightofX), new Point(panel1.Width, heightofX)); //x
            DrawAxis(g, new Point(widthofY,yAxOffset ), new Point(widthofY,panel1.Height )); //y
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            widthofY -= 2;
            g.Clear(panel1.BackColor);
            g = panel1.CreateGraphics();
            DrawAxis(g, new Point(xAxOffset, heightofX), new Point(panel1.Width, heightofX)); //x
            DrawAxis(g, new Point(widthofY, yAxOffset), new Point(widthofY, panel1.Height)); //y
            DrawSin();
        }

        public void draw()
        {
            g.Clear(panel1.BackColor);
            g = panel1.CreateGraphics();
            DrawAxis(g, new Point(xAxOffset, heightofX), new Point(panel1.Width, heightofX)); //x
            DrawAxis(g, new Point(widthofY, yAxOffset), new Point(widthofY, panel1.Height)); //y
            DrawSin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            widthofY+=2;
            draw();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            heightofX -= 2;
            draw();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            heightofX += 2;
            draw();
        }

        private void DrawSin()
        {
            int x, y;
            int x2, y2;
            
            int scale = 50; // amplitude of one
           

            float amplitude = 1;
            float realamplitude = scale * amplitude;
            float frequency = 6;
            float phase = 0F;
            int samples;
            samples = panel1.Width-widthofY;
            int one = panel1.Width - widthofY;
            double ratio;
            float dx = one / samples;
            p = new Pen(col[comboBox1.SelectedIndex], 2);
            x = widthofY;
            y = heightofX; // start fom the current origin
             for(int i = 0; i< samples; i++)
            {
                   ratio = one / (i*dx);
                    x2 = widthofY + (int )(i*dx);
                 y2 = (int) (a *scale*Math.Sin((Math.PI / ratio)*f*2 - Math.PI +  phase*(Math.PI/(double)360)) + heightofX);
                 
                 g.DrawLine(p, new Point(x,y), new Point(x2,y2));

                 x = x2;
                 y = y2;

            }
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            if (str.Length == 0)
            {
                str = "1";
            }
            a = Double.Parse(str);
            draw();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            if (str.Length == 0)
            {
                str = "1";
            }
            f = Double.Parse(str);
            draw();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            p = new Pen(col[comboBox1.SelectedIndex], 2);
            draw();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string str = textBox3.Text;
            if (str.Length == 0)
            {
                str = "0";
            }
            phase = Double.Parse(str);
            draw();
        }
    }
}
