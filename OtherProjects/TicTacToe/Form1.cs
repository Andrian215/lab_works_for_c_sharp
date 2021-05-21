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
                if ((button1.Text == "X" & button2.Text == "X" & button3.Text == "X") | (button4.Text == "X" & button5.Text == "X" & button6.Text == "X") | (button7.Text == "X" & button8.Text == "X" & button9.Text == "X") | (button1.Text == "X" & button4.Text == "X" & button7.Text == "X") | (button2.Text == "X" & button5.Text == "X" & button8.Text == "X") | (button3.Text == "X" & button6.Text == "X" & button9.Text == "X") | (button1.Text == "X" & button5.Text == "X" & button9.Text == "X") | (button3.Text == "X" & button5.Text == "X" & button7.Text == "X"))
                {
                    timer2.Enabled = true;
                    timer2.Start();
                    i++;
                    label1.Text = $"{i}:{k}";
                    timer4.Start();
                    i1 = 0; i2 = 0; i3 = 0; i4 = 0; i5 = 0; i6 = 0; i7 = 0; i8 = 0; i9 = 0;
                }
                else if ((button1.Text == "O" & button2.Text == "O" & button3.Text == "O") | (button4.Text == "O" & button5.Text == "O" & button6.Text == "O") | (button7.Text == "O" & button8.Text == "O" & button9.Text == "O") | (button1.Text == "O" & button4.Text == "O" & button7.Text == "O") | (button2.Text == "O" & button5.Text == "O" & button8.Text == "O") | (button3.Text == "O" & button6.Text == "O" & button9.Text == "O") | (button1.Text == "O" & button5.Text == "O" & button9.Text == "O") | (button3.Text == "O" & button5.Text == "O" & button7.Text == "O"))
                {
                    timer3.Enabled = true;
                    timer3.Start();
                    k++;
                    label1.Text = $"{i}:{k}";
                    timer4.Start();
                    i1 = 0; i2 = 0; i3 = 0; i4 = 0; i5 = 0; i6 = 0; i7 = 0; i8 = 0; i9 = 0;
                }
            }
            else if (button1.Text != "" & button2.Text != "" & button3.Text != "" & button4.Text != "" & button5.Text != "" & button6.Text != "" & button7.Text != "" & button8.Text != "" & button9.Text != "")
            {
                timer1.Enabled = true;
                timer1.Start();
                i1 = 0; i2 = 0; i3 = 0; i4 = 0; i5 = 0; i6 = 0; i7 = 0; i8 = 0; i9 = 0;
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
            }
        }
    
    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int i1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(i1 == 0)
            {
                button1.Text = Function(b);
                i1++;
            }
            F();
        }

        int i2 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (i2 == 0)
            {
                button2.Text = Function(b);
                i2++;
            }
            F();
        }

        int i3 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (i3 == 0)
            {
                button3.Text = Function(b);
                i3++;
            }
            F();
        }

        int i4 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (i4 == 0)
            {
                button4.Text = Function(b);
                i4++;
            }
            F();
        }

        int i5 = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (i5 == 0)
            {
                button5.Text = Function(b);
                i5++;
            }
            F();
        }

        int i6 = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (i6 == 0)
            {
                button6.Text = Function(b);
                i6++;
            }
            F();
        }

        int i7 = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            if (i7 == 0)
            {
                button7.Text = Function(b);
                i7++;
            }
            F();
        }

        int i8 = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            if (i8 == 0)
            {
                button8.Text = Function(b);
                i8++;
            }
            F();
        }

        int i9 = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            if (i9 == 0)
            {
                button9.Text = Function(b);
                i9++;
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
            label2.Visible = true;
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label2.Text = "2ND PLAYER WON!";
            label2.Visible = true;
            timer3.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Enabled = true;
            label2.Visible = false;
        }
    }
}
