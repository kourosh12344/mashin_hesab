using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mashin_hesab_T_
{
    public partial class Form1 : Form
    {
        double asswe , num1 , num2;
        string btn;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = string.Empty;
            btn = "+";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = string.Empty;
            btn = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = string.Empty;
            btn = "/";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (btn.ToString() == "+")
            {
                num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(num1 + num2);
            }
            if (btn.ToString() == "-")
            {
                num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(num1 - num2);
            }
            if (btn.ToString() == "*")
            {
                num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(num1 * num2);
            }
            if (btn.ToString() == "/")
            {
                num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(num1 / num2);
            }
        }

        
private void btnSub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = string.Empty;
            btn = "-";
        }
    }
}
