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
    public partial class Calculator : Form
    {
        float a, b;
        double c, d;
        int count, q=1, s=1;
        bool semn = true;
        public Calculator()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                s = 1;
                label1.Text = "";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 0;
            }
            else if (s==1)
            {
                textBox1.Text = textBox1.Text + 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                s = 1;
                label1.Text = "";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 1;
            }
            else if (s == 1)
            {
                textBox1.Text = textBox1.Text + 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                s = 1;
                label1.Text = "";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 2;
            }
            else if (s == 1)
            {
                textBox1.Text = textBox1.Text + 2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                s = 1;
                label1.Text = "";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 3;
            }
            else if (s == 1)
            {
                textBox1.Text = textBox1.Text + 3;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                s = 1;
                label1.Text = "";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 4;
            }
            else if (s == 1)
            {
                textBox1.Text = textBox1.Text + 4;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                s = 1;
                label1.Text = "";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 5;
            }
            else if (s == 1)
            {
                textBox1.Text = textBox1.Text + 5;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                s = 1;
                label1.Text = "";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 6;
            }
            else if (s == 1)
            {
                textBox1.Text = textBox1.Text + 6;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                s = 1;
                label1.Text = "";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 7;
            }
            else if (s == 1)
            {
                textBox1.Text = textBox1.Text + 7;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                s = 1;
                label1.Text = "";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 8;
            }
            else if (s == 1)
            {
                textBox1.Text = textBox1.Text + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                s = 1;
                label1.Text = "";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + 9;
            }
            else if (s == 1)
            {
                textBox1.Text = textBox1.Text + 9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            q = 1;
                c = double.Parse(textBox1.Text);
            if (c > 0)
            {
                textBox1.Clear();
                count = 7;
                label1.Text = " ";
                calculate();
                semn = true;
            }
                      
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text != "" && textBox1.Text != "")
            {
                calculate();
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    count = 4;
                    textBox1.Text = "";
                    label1.Text = a.ToString() + " / ";
                    semn = true;
                    q = 1;
                    s = 1;
                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    count = 4;
                    textBox1.Text = "";
                    label1.Text = a.ToString() + " / ";
                    semn = true;
                    q = 1;
                    s = 1;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text != "" && textBox1.Text != "")
            {
                calculate();
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    count = 3;
                    textBox1.Text = "";
                    label1.Text = a.ToString() + " * ";
                    semn = true;
                    q = 1;
                    s = 1;
                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    count = 3;
                    textBox1.Text = "";
                    label1.Text = a.ToString() + " * ";
                    semn = true;
                    q = 1;
                    s = 1;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label1.Text != "" && textBox1.Text != "")
            {
                calculate();
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    count = 2;
                    textBox1.Text = "";
                    label1.Text = a.ToString() + " - ";
                    semn = true;
                    q = 1;
                    s = 1;
                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    count = 2;
                    textBox1.Text = "";
                    label1.Text = a.ToString() + " - ";
                    semn = true;
                    q = 1;
                    s = 1;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                calculate();
                if (label1.Text != "" && textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    count = 1;
                    textBox1.Text = "";
                    label1.Text = a.ToString() + " + ";
                    semn = true;
                    q = 1;
                    s = 1;
                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    count = 1;
                    textBox1.Text = "";
                    label1.Text = a.ToString() + " + ";
                    semn = true;
                    q = 1;
                    s = 1;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (q == 1)
                {
                    textBox1.Text = textBox1.Text + ",";
                    q = q - 1;
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = float.Parse(textBox1.Text);
                count = 8;
                label1.Text = textBox1.Text + "%";
                textBox1.Clear();
                calculate();
                semn = true;
                s = 1;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 6;
                label1.Text = " ";
                calculate();
                semn = true;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                q = 1;
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 5;
                label1.Text = a.ToString() + " ^2";
                calculate();
                semn = true;
                s = 1;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            s = 0;
            q = 1;
            if (label1.Text != "")
            {
                calculate();
                label1.Text = "";
            }
            a = 0;
            c = 0;
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                if (label1.Text != "")
                {
                    calculate();
                    if (label1.Text != "" && textBox1.Text != "")
                    {
                        a = float.Parse(textBox1.Text);
                        count = 1;
                        textBox1.Text = "";
                        label1.Text = a.ToString() + " + ";
                        semn = true;
                        q = 1;
                    }
                }
                else
                {
                    if (textBox1.Text != "")
                    {
                        a = float.Parse(textBox1.Text);
                        count = 1;
                        textBox1.Text = "";
                        label1.Text = a.ToString() + " + ";
                        semn = true;
                        q = 1;
                    }
                }
            }
            if (e.KeyCode == Keys.Multiply)
            {
                if (label1.Text != "" && textBox1.Text != "")
                {
                    calculate();
                    if (textBox1.Text != "")
                    {
                        a = float.Parse(textBox1.Text);
                        count = 3;
                        textBox1.Text = "";
                        label1.Text = a.ToString() + " * ";
                        semn = true;
                        q = 1;
                    }
                }
                else
                {
                    if (textBox1.Text != "")
                    {
                        a = float.Parse(textBox1.Text);
                        count = 3;
                        textBox1.Text = "";
                        label1.Text = a.ToString() + " * ";
                        semn = true;
                        q = 1;
                    }
                }
            }
            if (e.KeyCode == Keys.Divide)
            {
                if (label1.Text != "" && textBox1.Text != "")
                {
                    calculate();
                    if (textBox1.Text != "")
                    {
                        a = float.Parse(textBox1.Text);
                        count = 4;
                        textBox1.Text = "";
                        label1.Text = a.ToString() + " / ";
                        semn = true;
                        q = 1;
                    }
                }
                else
                {
                    if (textBox1.Text != "")
                    {
                        a = float.Parse(textBox1.Text);
                        count = 4;
                        textBox1.Text = "";
                        label1.Text = a.ToString() + " / ";
                        semn = true;
                        q = 1;
                    }
                }
            }
            if (e.KeyCode == Keys.Subtract)
            {
                if (label1.Text != "" && textBox1.Text != "")
                {
                    calculate();
                    if (textBox1.Text != "")
                    {
                        a = float.Parse(textBox1.Text);
                        count = 2;
                        textBox1.Text = "";
                        label1.Text = a.ToString() + " - ";
                        semn = true;
                        q = 1;
                    }
                }
                else
                {
                    if (textBox1.Text != "")
                    {
                        a = float.Parse(textBox1.Text);
                        count = 2;
                        textBox1.Text = "";
                        label1.Text = a.ToString() + " - ";
                        semn = true;
                        q = 1;
                    }
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    calculate();
                    label1.Text = "";
                }
            }
            if (e.KeyCode == Keys.Back)
            {
                label1.Text = "";
                textBox1.Text = "";
                q = 1;
            }
            if (e.KeyCode == Keys.Decimal)
            {
                if (!textBox1.Text.Contains(","))
                {
                    if (q == 1)
                    {
                        q = q - 1;
                        textBox1.Text = textBox1.Text + ",";
                        textBox1.Select(textBox1.Text.Length, 0);
                    }
                }
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
  
        }

        private void button13_Click(object sender, EventArgs e)
        {
            q = 1;
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (semn == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                semn = false;
            }
            else if (semn == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                semn = true;
            }
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = a * a;
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = 1 / a;
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    d = Math.Sqrt(c);
                    textBox1.Text = d.ToString();
                    break;
                case 8:
                    b = a / 100;
                    textBox1.Text = b.ToString();
                    break;
                default:

                    break;
            }
        }
    }
}
