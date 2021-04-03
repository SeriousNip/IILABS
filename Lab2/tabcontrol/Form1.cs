using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabcontrol
{
    public partial class Form1 : Form
    {

        string[] lst = { "Golf 4", "Audi A4", "BMW M3" };

        public Form1()
        {
            InitializeComponent();
            for( int i=0; i < lst.Length; i++)
            {
                listBox1.Items.Add(lst[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0) pictureBox1.Image = tabcontrol.Properties.Resources.golf;
            if (listBox1.SelectedIndex == 1) pictureBox1.Image = tabcontrol.Properties.Resources.a4;
            if (listBox1.SelectedIndex == 2) pictureBox1.Image = tabcontrol.Properties.Resources.m3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton4.Checked)
            {
                textBox1.Text = "First Name Middle Name";
            }
            else
            if (radioButton2.Checked && radioButton4.Checked)
            {
                textBox1.Text = "Last Name Middle Name";
            }
            else
            if (radioButton1.Checked && radioButton3.Checked)
            {
                textBox1.Text = "First Name CNP";
            }
            else
            if (radioButton2.Checked && radioButton3.Checked)
            {
                textBox1.Text = "Last Name CNP";
            }
            else textBox1.Text = "";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
