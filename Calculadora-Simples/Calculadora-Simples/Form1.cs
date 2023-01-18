using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado_soma;
            n1 = Convert.ToInt16(textBox1.Text);
            n2 = Convert.ToInt16(textBox2.Text);
            resultado_soma = n1 + n2;
            label4.Text = Convert.ToString(resultado_soma);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado_Mult;
            n1 = Convert.ToInt16(textBox1.Text);
            n2 = Convert.ToInt16(textBox2.Text);
            resultado_Mult = n1 * n2;
            label4.Text = Convert.ToString(resultado_Mult);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado_Sub;
            n1 = Convert.ToInt16(textBox1.Text);
            n2 = Convert.ToInt16(textBox2.Text);
            resultado_Sub = n1 - n2;
            label4.Text = Convert.ToString(resultado_Sub);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double n1, n2, resultado_div;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            resultado_div = n1 / n2;
            label4.Text = Convert.ToString((double)resultado_div);
        }
    }
}
