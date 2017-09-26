using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text);
            double b = double.Parse(txt2.Text);
            double c;
            c = a + b;
            txtkq.Text = c.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text);
            double b = double.Parse(txt2.Text);
            double c;
            c = a - b;
            txtkq.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text);
            double b = double.Parse(txt2.Text);
            double c;
            c = a + b;
            txtkq.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text);
            double b = double.Parse(txt2.Text);
            double c;
            if (a != 0)
            {
                c = a / b;
                txtkq.Text = c.ToString();
            }
            else
                c = "vui long nhap so khac 0";
            txtkq.Text = c.ToString();
        }
    }
}
