using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор__Demo_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           this.Width = 243;
        }
        double a, c;
        int count, p=0, t=1;
        string hstA, hstB, hstRes;
        double Memory = 0;
        bool HistButt = true;

        
        private void history()
        {
            hstRes = hstA + hstB + " = " + c.ToString() + "\n" + "\n";
            label2.Text += hstRes;

        }
        private void calculate()
        {
            hstB = textBox1.Text;
            if (textBox1.Text != "")
            {
                switch (count)
                {
                    case 1:
                        c += double.Parse(textBox1.Text);
                        textBox1.Text = c.ToString();
                        break;
                    case 2:
                        c -= double.Parse(textBox1.Text);
                        textBox1.Text = c.ToString();
                        break;
                    case 3:
                        c *= double.Parse(textBox1.Text);
                        textBox1.Text = c.ToString();
                        break;
                    case 4:
                        c /= double.Parse(textBox1.Text);
                        textBox1.Text = c.ToString();
                        break;
                    case 5:
                        c *= double.Parse(textBox1.Text) / 100;
                        textBox1.Text = c.ToString();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                textBox1.Text = c.ToString();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            ++t;
            if (t == 1 && textBox1.Text == null || t >= 2)
            {
                textBox1.Text += 0;
            }
            else if (t == 1 && textBox1.Text == c.ToString())
            {
                textBox1.Text = "0";
            }
        }           
        private void button1_Click(object sender, EventArgs e)
        {
            ++t;
            if (t == 1 && textBox1.Text == null || t >= 2)
            {
                textBox1.Text += 1;
            }
            else if (t == 1 && textBox1.Text == c.ToString())
            {
                textBox1.Text = "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ++t;
            if (t == 1 && textBox1.Text == null || t >= 2)
            {
                textBox1.Text += 2;
            }
            else if (t == 1 && textBox1.Text == c.ToString())
            {
                textBox1.Text = "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ++t;
            if (t == 1 && textBox1.Text == null || t >= 2)
            {
                textBox1.Text += 3;
            }
            else if (t == 1 && textBox1.Text == c.ToString())
            {
                textBox1.Text = "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ++t;
            if (t == 1 && textBox1.Text == null || t >= 2)
            {
                textBox1.Text += 4;
            }
            else if (t == 1 && textBox1.Text == c.ToString())
            {
                textBox1.Text = "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ++t;
            if (t == 1 && textBox1.Text == null || t >= 2)
            {
                textBox1.Text += 5;
            }
            else if (t == 1 && textBox1.Text == c.ToString())
            {
                textBox1.Text = "5";
            }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            ++t;
            if (t == 1 && textBox1.Text == null || t >= 2)
            {
                textBox1.Text += 6;
            }
            else if (t == 1 && textBox1.Text == c.ToString())
            {
                textBox1.Text = "6";
            }  
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            ++t;
            if (t == 1 && textBox1.Text == null || t >= 2)
            {
                textBox1.Text += 7;
            }
            else if (t == 1 && textBox1.Text == c.ToString())
            {
                textBox1.Text = "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            ++t;
            if (t == 1 && textBox1.Text == null || t >= 2)
            {
                textBox1.Text += 8;
            }
            else if (t == 1 && textBox1.Text == c.ToString())
            {
                textBox1.Text = "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ++t;
            if (t == 1 && textBox1.Text == null || t >= 2)
            {
                textBox1.Text += 9;
            }
            else if (t == 1 && textBox1.Text == c.ToString())
            {
                textBox1.Text = "9";
            }
        }
        private void buttonP_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ++p;
                a = double.Parse(textBox1.Text);
                c = (p == 1) ? a : c + double.Parse(textBox1.Text);
                hstB = textBox1.Text;
                textBox1.Text = c.ToString();
                t = 0;
                count = 1;
                label1.Text += a.ToString() + "+";
            }     
        }

       

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void ButtonM_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ++p;
                a = double.Parse(textBox1.Text);
                c = (p == 1) ? a : c - double.Parse(textBox1.Text);
                hstB = textBox1.Text;
                textBox1.Text = c.ToString();
                t = 0;
                count = 2;
                label1.Text += a.ToString() + "-";
            }
        }
        private void buttonX_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ++p;
                a = double.Parse(textBox1.Text);
                c = (p == 1) ? a : c * double.Parse(textBox1.Text);
                hstB = textBox1.Text;
                textBox1.Text = c.ToString();
                t = 0;
                count = 3;
                label1.Text += a.ToString() + "*";
            }
        }
        private void buttonD_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ++p;
                a = double.Parse(textBox1.Text);
                c = (p == 1) ? a : c / double.Parse(textBox1.Text);
                hstB = textBox1.Text;
                textBox1.Text = c.ToString();
                t = 0;
                count = 4;
                label1.Text += a.ToString() + "÷";
            }
        }
        private void buttonR_Click(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {
                calculate();
            }
            else
            {
                textBox1.Text = c.ToString();
            }
            hstA = label1.Text;
            label1.Text = "";
            history();
            c = 0; p =0;
           
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            c = 0; p = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
                hstB = textBox1.Text;
                textBox1.Clear();
                textBox1.Text = Math.Sqrt(a).ToString();
                label1.Text = "";
            }
        }

        private void buttonMm_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Memory -= double.Parse(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void buttonMp_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Memory += double.Parse(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void CHistory_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }
       
        private void button12_Click(object sender, EventArgs e)
        {
            
            if (HistButt == true)
            {
                label2.Visible = true;
                CHistory.Visible = true;
                this.Width = 377;
                HistButt = false;
            }
            else 
            if(HistButt == false)
            {
                label2.Visible = false;
                CHistory.Visible = false;
                this.Width = 243;
                HistButt = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            Memory = 0;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Memory = double.Parse(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                c = double.Parse(textBox1.Text);
                hstB = textBox1.Text;
                textBox1.Clear();
                count = 5;
                label1.Text = c.ToString() + "%";
            }
        }

        private void ButtonMR_Click(object sender, EventArgs e)
        {
            textBox1.Text = Memory.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.IndexOf(",") == -1))
                textBox1.Text += ",";
        }
    }

}