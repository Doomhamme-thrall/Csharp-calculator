using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using Expression = NCalc.Expression;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("8");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(".");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = richTextBox1.Text;
                var expr = new Expression(expression);
                var result = expr.Evaluate();
                richTextBox1.AppendText(Environment.NewLine + "Result: " + result.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double random1 = new Random().NextDouble();
            int random2 = new Random().Next(1, 100);
            double random = random1 * random2;
            richTextBox1.AppendText(random.ToString());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("*");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("4");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("6");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("9");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("0");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("+");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text) != true)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.TextLength - 1);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("-");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("/"); // Division button
        }
    }
}