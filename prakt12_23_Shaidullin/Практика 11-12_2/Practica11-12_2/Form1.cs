using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica11_12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            triangle.CreateObject();

            triangle.a = Convert.ToDouble(numericUpDown1.Text);
            triangle.b = Convert.ToDouble(numericUpDown2.Text);
            triangle.c = Convert.ToDouble(numericUpDown3.Text);
            triangle.h = Convert.ToDouble(numericUpDown4.Text);

            triangle.x1 = Convert.ToDouble(numericUpDown5.Text);
            triangle.y1 = Convert.ToDouble(numericUpDown6.Text);
            triangle.x2 = Convert.ToDouble(numericUpDown7.Text);
            triangle.y2 = Convert.ToDouble(numericUpDown8.Text);
            triangle.x3 = Convert.ToDouble(numericUpDown9.Text);
            triangle.y3 = Convert.ToDouble(numericUpDown10.Text);


            label11.Text = "Площадь: " + triangle.Area();
            label12.Text = "Периметр: " + triangle.Perimeter();
            label13.Text = "Точка пересечения медиан: " + triangle.PointMedian();
        }
    }
}
