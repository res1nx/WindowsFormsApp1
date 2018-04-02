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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text) * Math.Pow(10, Convert.ToDouble(textBox5.Text));
            textBox4.Text += "X = " + textBox1.Text + '\r' + '\n';
            double y = Convert.ToDouble(textBox2.Text);
            textBox4.Text += "Y = " + textBox2.Text + '\r' + '\n';
            double z = Convert.ToDouble(textBox3.Text);
            textBox4.Text += "Z = " + textBox3.Text + '\r' + '\n';

            double a = Math.Sqrt(10 * (Math.Pow(x, 1 / 3) + Math.Pow(x, y + 2)));
            double b = Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y);
            double u = a * b;

            textBox4.Text += string.Format(@"Результат U: {0:#.000} ", u) + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Text += "Практ.раб N1 Ст.гр. 165 Ефимов Г." + '\r' + '\n';
        }
    }
}
