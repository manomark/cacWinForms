using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double val1 = 0, val2 = 0;
        string op;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += button1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(textBox.Text);
            op = add.Text;
            textBox.Text = "";
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += button2.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += button8.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += button7.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox.Text += button16.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox.Text += button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox.Text += button15.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox.Text += button10.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox.Text += button12.Text;
        }

        private void sub(object sender, EventArgs e)
        {
            val1 = double.Parse(textBox.Text);
            op = sub.Text;
            textBox.Text = "";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(textBox.Text);
            op = mul.Text;
            textBox.Text = "";

        }

        private void div_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(textBox.Text);
            op = div.Text;
            textBox.Text = "";
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            val1 = double.Parse(textBox.Text);
            op = add.Text;
            textBox.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(textBox.Text);
            if (op == "+")
            {
                textBox.Text = (val1 + v2).ToString();
            }
        }
    }
}
