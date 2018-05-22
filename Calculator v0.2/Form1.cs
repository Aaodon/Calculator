using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        // Codded by Aaodon ©
        // Data Type Variable Name = Value;
        {
            InitializeComponent();
        }
        double sayi, sayi2, sonuc;
        string islem;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        void sayiyaz1()
        {
            if (textBox1.Text != "")
            {
                sayi = Convert.ToDouble(textBox1.Text);
                label1.Text = sayi.ToString() + islem.ToString();
                textBox1.Text = "";
            }
            else label1.Text = "You have to enter a number";
            
        }

        void sayiyaz2()
        {
            label1.Text = sayi.ToString() + islem.ToString() + sayi2.ToString()+"="+sonuc.ToString();
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            islem = "+";
            sayiyaz1();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islem = "-";
            sayiyaz1();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            islem = "*";
            sayiyaz1();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(button17.Text == "Open History")
            {
                groupBox1.Visible = true;
                this.Size = new Size(396, 366);
                button17.Text = "Close the History";
            }
            else
            {
                groupBox1.Visible = false;
                this.Size = new Size(219, 366);
                button17.Text = "Open History";
            }
            /* 219; 366
            396; 366 */
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            sayi = 0;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            islem = "/";
            sayiyaz1();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") sayi2 = Convert.ToDouble(textBox1.Text);
            else label1.Text = "You forgot enter the number";
            switch (islem)
            {
                case "+":
                    sonuc = sayi + sayi2;
                    sayiyaz2();
                break;

                case "-":
                    sonuc = sayi - sayi2;
                    sayiyaz2();
                break;

                case "*":
                    sonuc = sayi * sayi2;
                    sayiyaz2();
                break;

                case "/":
                    sonuc = sayi / sayi2;
                    sayiyaz2();
                break;

            }
            listBox1.Items.Add(label1.Text);
        }
    }
}
