using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Game g;
        int play = 0;

        public Form1()
        {
            InitializeComponent();
            g = new Game();
            play = 1;
        }

        private void bezárToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool dontetlen()
        {
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false
                 && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false
                && button8.Enabled == false && button9.Enabled == false)
            {
                return true;
            }

            return false;
        }

        private void újJátékToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g = new Game();
            play = 1;
            label1.Text = "Játék folyamatban";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dontetlen() == true)
            {
                label1.Text = "Döntetlen";
            }

            if (play == 1)
            {
                button1.Text = "X";
                button1.Enabled = false;
                g.tomb[0, 0] = play;

                if (g.checkWinner(play) == true)
                {
                    label1.Text = "X nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }

                play = 2;
                return;
            }

            if (play == 2)
            {
                button1.Text = "O";
                button1.Enabled = false;
                g.tomb[0, 0] = play;

                if (g.checkWinner(play) == true)
                {
                    label1.Text = "O nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }

                play = 1;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dontetlen() == true)
            {
                label1.Text = "Döntetlen";
            }

            if (play == 1)
            {
                button2.Text = "X";
                button2.Enabled = false;
                g.tomb[0, 1] = play;

                if (g.checkWinner(play) == true)
                {
                    label1.Text = "X nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }

                play = 2;
                return;
            }
            if (play == 2)
            {
                button2.Text = "O";
                button2.Enabled = false;
                g.tomb[0, 1] = play;

                if (g.checkWinner(play) == true)
                {
                    label1.Text = "O nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }

                play = 1;
                return;
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dontetlen() == true)
            {
                label1.Text = "Döntetlen";
            }

            if (play == 1)
            {
                button3.Text = "X";
                button3.Enabled = false;
                g.tomb[0, 2] = play;

                if (g.checkWinner(play) == true)
                {
                    label1.Text = "X nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }

                play = 2;
                return;
            }

            if (play == 2)
            {
                button3.Text = "O";
                button3.Enabled = false;
                g.tomb[0, 2] = play;

                if (g.checkWinner(play) == true)
                {
                    label1.Text = "O nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }

                play = 1;
                return;
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dontetlen() == true)
            {
                label1.Text = "Döntetlen";
            }

            if (play == 1)
            {
                button4.Text = "X";
                button4.Enabled = false;
                g.tomb[1, 0] = play;

                if (g.checkWinner(play) == true)
                {
                    label1.Text = "X nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }

                play = 2;
                return;
            }

            if (play == 2)
            {
                button4.Text = "O";
                button4.Enabled = false;
                g.tomb[1, 0] = play;
                if (g.checkWinner(play) == true)
                {
                    label1.Text = "O nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                play = 1;
                return;
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dontetlen() == true)
            {
                label1.Text = "Döntetlen";
            }

            if (play == 1)
            {
                button5.Text = "X";
                button5.Enabled = false;
                g.tomb[1, 1] = play;
                if (g.checkWinner(play) == true)
                {
                    label1.Text = "X nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                play = 2;
                return;
            }

            if (play == 2)
            {
                button5.Text = "O";
                button5.Enabled = false;
                g.tomb[1, 1] = play;
                if (g.checkWinner(play) == true)
                {
                    label1.Text = "O nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                play = 1;
                return;
            } 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dontetlen() == true)
            {
                label1.Text = "Döntetlen";
            }

            if (play == 1)
            {
                button6.Text = "X";
                button6.Enabled = false;
                g.tomb[1, 2] = play;
                if (g.checkWinner(play) == true)
                {
                    label1.Text = "X nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                play = 2;
                return;
            }

            if (play == 2)
            {
                button6.Text = "O";
                button6.Enabled = false;
                g.tomb[1, 2] = play;
                if (g.checkWinner(play) == true)
                {
                    label1.Text = "O nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                play = 1;
                return;
            } 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dontetlen() == true)
            {
                label1.Text = "Döntetlen";
            }

            if (play == 1)
            {
                button7.Text = "X";
                button7.Enabled = false;
                g.tomb[2, 0] = play;
                if (g.checkWinner(play) == true)
                {
                    label1.Text = "X nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                play = 2;
                return;
            }
            if (play ==2)
            {
                button7.Text = "O";
                button7.Enabled = false;
                g.tomb[2, 0] = play;
                if (g.checkWinner(play) == true)
                {
                    label1.Text = "O nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                play = 1;
                return;
            } 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dontetlen() == true)
            {
                label1.Text = "Döntetlen";
            }

            if (play == 1)
            {
                button8.Text = "X";
                button8.Enabled = false;
                g.tomb[2, 1] = play;
                if (g.checkWinner(play) == true)
                {
                    label1.Text = "X nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                play = 2;
                return;
            }
            if (play == 2)
            {
                button8.Text = "O";
                button8.Enabled = false;
                g.tomb[2, 1] = play;
                if (g.checkWinner(play) == true)
                {
                    label1.Text = "O nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                play = 1;
                return;
            } 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dontetlen() == true)
            {
                label1.Text = "Döntetlen";
            }

            if (play == 1)
            {
                button9.Text = "X";
                button9.Enabled = false;
                g.tomb[2, 2] = play;
                if (g.checkWinner(play) == true)
                {
                    label1.Text = "X nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                play = 2;
                return;
            }
            if (play == 2)
            {
                button9.Text = "O";
                button9.Enabled = false;
                g.tomb[2, 2] = play;
                if (g.checkWinner(play) == true)
                {
                    label1.Text = "O nyert";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                }
                play = 2;
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


    class Game {
        public int[,] tomb = new int[3, 3];
        public int[] tomb2 = new int[9];
        public static int counter = 0;
        public Game()
        {
            initGame();
            counter = 0;
        }

        public void initGame()
        {
            int i, j, k;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    tomb[i,j] = 0;
                }
            }

            for (k = 0; k < 9; k++)
            {
                tomb2[k] = 0;
            }
        }

        public bool checkWinner(int player)
        {
            int i, j;
            for (i = 0; i < 3; i++)
            {
                if (tomb[i, 0] == player && tomb[i, 1] == player && tomb[i, 2] == player)
                {
                  return  true;
                }
            }

            for (i = 0; i < 3; i++)
            {
                if (tomb[0,i] == player && tomb[1,i ] == player && tomb[2,i ] == player)
                {
                    return true;
                }
            }
            if (tomb[0, 0] == player && tomb[1, 1] == player && tomb[2, 2] == player)
            {
                return true;
            }
            if (tomb[0, 2] == player && tomb[1, 1] == player && tomb[2, 0] == player)
            {
                return true;
            }

            return false;
        }
        
    }
}
