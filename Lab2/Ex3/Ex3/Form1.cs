using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text==""||textBox2.Text=="")
            {

                MessageBox.Show("Nu au fost introduse numere");
                

            }
            else
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(a + b);
            }
           
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void diferentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" )
            {

                MessageBox.Show("Nu au fost introduse numere");


            }
            else
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(a - b);
            }

        }

        private void produsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {

                MessageBox.Show("Nu au fost introduse numere");


            }
            else
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(a * b);
            }

        }

        private void raportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" )
            {

                MessageBox.Show("Nu au fost introduse numere");


            }
            else
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(a / b);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&&textBox2.Text!="")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                textBox1.Text = Convert.ToString(b);
                textBox2.Text = Convert.ToString(a);
                textBox3.Text = "";
            }
        }
    }
    
    
    
}
