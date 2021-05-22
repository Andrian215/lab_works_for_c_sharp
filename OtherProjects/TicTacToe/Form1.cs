using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGame
{
    public partial class Form1 : Form
    {
        int a = 1;
        string b = "";
        int[] array_for_buttons = {0,0,0,0,0,0,0,0,0};
        public string Function(string button_name)
        {
            if (a == 1)
            {
                button_name = "X";
                a--;
            }
            else
            {
                button_name = "O";
                a++;
            }
            return button_name;
        }
        uint i = 0;
        uint k = 0;
    private void F()
        {
            if ((button1.Text == button2.Text & button1.Text == button3.Text & (button1.Text != "" || button2.Text != "" || button3.Text != "")) | (button4.Text == button5.Text && button4.Text == button6.Text & (button4.Text != "" || button5.Text != "" || button6.Text != "")) | (button7.Text == button8.Text && button7.Text == button9.Text) & (button7.Text != "" || button8.Text != "" || button9.Text != "") | (button1.Text == button4.Text && button1.Text == button7.Text) & (button1.Text != "" || button4.Text != "" || button7.Text != "") | (button2.Text == button5.Text && button2.Text == button8.Text) & (button2.Text != "" || button5.Text != "" || button8.Text != "") | (button3.Text == button6.Text && button3.Text == button9.Text) & (button3.Text != "" || button6.Text != "" || button9.Text != "") | (button1.Text == button5.Text && button1.Text == button9.Text) & (button1.Text != "" || button5.Text != "" || button9.Text != "") | (button3.Text == button5.Text && button3.Text == button7.Text) & (button3.Text != "" || button5.Text != "" || button7.Text != ""))
            {
                timer1.Enabled = true;
                timer1.Start();
                if ((button1.Text == "X" & button2.Text == "X" & button3.Text == "X") || (button4.Text == "X" & button5.Text == "X" & button6.Text == "X") || (button7.Text == "X" & button8.Text == "X" & button9.Text == "X") || (button1.Text == "X" & button4.Text == "X" & button7.Text == "X") || (button2.Text == "X" & button5.Text == "X" & button8.Text == "X") || (button3.Text == "X" & button6.Text == "X" & button9.Text == "X") || (button1.Text == "X" & button5.Text == "X" & button9.Text == "X") || (button3.Text == "X" & button5.Text == "X" & button7.Text == "X"))
                {
                    timer2.Enabled = true;
                    timer2.Start();
                    i++;
                    label1.Text = $"{i}:{k}";
                    timer4.Start();
                    array_for_buttons[0] = 0; array_for_buttons[0] = 0; array_for_buttons[1] = 0; array_for_buttons[2] = 0; array_for_buttons[3] = 0; array_for_buttons[4] = 0; array_for_buttons[5] = 0; array_for_buttons[6] = 0; array_for_buttons[7] = 0; array_for_buttons[8] = 0; 
                }
                else if ((button1.Text == "O" & button2.Text == "O" & button3.Text == "O") || (button4.Text == "O" & button5.Text == "O" & button6.Text == "O") || (button7.Text == "O" & button8.Text == "O" & button9.Text == "O") || (button1.Text == "O" & button4.Text == "O" & button7.Text == "O") || (button2.Text == "O" & button5.Text == "O" & button8.Text == "O") || (button3.Text == "O" & button6.Text == "O" & button9.Text == "O") || (button1.Text == "O" & button5.Text == "O" & button9.Text == "O") || (button3.Text == "O" & button5.Text == "O" & button7.Text == "O"))
                {
                    timer3.Enabled = true;
                    timer3.Start();
                    k++;
                    label1.Text = $"{i}:{k}";
                    timer4.Start();
                    array_for_buttons[0] = 0; array_for_buttons[0] = 0; array_for_buttons[1] = 0; array_for_buttons[2] = 0; array_for_buttons[3] = 0; array_for_buttons[4] = 0; array_for_buttons[5] = 0; array_for_buttons[6] = 0; array_for_buttons[7] = 0; array_for_buttons[8] = 0; 
                }
            }
            else if (button1.Text != "" & button2.Text != "" & button3.Text != "" & button4.Text != "" & button5.Text != "" & button6.Text != "" & button7.Text != "" & button8.Text != "" & button9.Text != "")
            {
                timer1.Enabled = true;
                timer1.Start();
                array_for_buttons[0] = 0; array_for_buttons[0] = 0; array_for_buttons[1] = 0; array_for_buttons[2] = 0; array_for_buttons[3] = 0; array_for_buttons[4] = 0; array_for_buttons[5] = 0; array_for_buttons[6] = 0; array_for_buttons[7] = 0; array_for_buttons[8] = 0; 
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
            }
        }

        public void Game_Over()
        {
            if (i == 5 || k == 5)
            {
                label2.Visible = true;
                label3.Visible = true;
                timer5.Enabled = true;
                timer5.Start();
            }
            else
            {
                label2.Visible = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(array_for_buttons[0] == 0)
            {
                button1.Text = Function(b);
                array_for_buttons[0] = 1;
            }
            F();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (array_for_buttons[1] == 0)
            {
                button2.Text = Function(b);
                array_for_buttons[1] = 1;
            }
            F();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (array_for_buttons[2] == 0)
            {
                button3.Text = Function(b);
                array_for_buttons[2] = 1;
            }
            F();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (array_for_buttons[3] == 0)
            {
                button4.Text = Function(b);
                array_for_buttons[3] = 1;
            }
            F();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (array_for_buttons[4] == 0)
            {
                button5.Text = Function(b);
                array_for_buttons[4] = 1;
            }
            F();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (array_for_buttons[5] == 0)
            {
                button6.Text = Function(b);
                array_for_buttons[5] = 1;
            }
            F();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (array_for_buttons[6] == 0)
            {
                button7.Text = Function(b);
                array_for_buttons[6] = 1;
            }
            F();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (array_for_buttons[7] == 0)
            {
                button8.Text = Function(b);
                array_for_buttons[7] = 1;
            }
            F();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (array_for_buttons[8] == 0)
            {
                button9.Text = Function(b);
                array_for_buttons[8] = 1;
            }
            F();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = "1ST PLAYER WON!";
            Game_Over();
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label2.Text = "2ND PLAYER WON!";
            Game_Over();
            timer3.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Enabled = true;
            label2.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = ""; button2.Text = ""; button3.Text = ""; button4.Text = ""; button5.Text = ""; button6.Text = ""; button7.Text = ""; button8.Text = ""; button9.Text = "";
            label3.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            i = 0; k = 0;
            label1.Text = $"{i}:{k}";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            button10.Visible = true;
            button11.Visible = true;
            timer5.Enabled = false;
        }
    }
}