using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public char op = '+';
        public Form1()
        {
            this.BackColor = Color.FromArgb(45, 51, 53);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addition_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            op = '+';
            Console.WriteLine(op);
        }
        private void substraction_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            op = '-';
            Console.WriteLine(op);
        }
        private void multiplication_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            op = '*';
            Console.WriteLine(op);
        }
        private void division_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            op = '/';
            Console.WriteLine(op);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (op == '+')
            {
                result.Text = Convert.ToString(Convert.ToDouble(el1.Text) + Convert.ToDouble(el2.Text));
                el1.Text = "";
                el2.Text = "";
            }

            if (op == '-')
            {
                result.Text = Convert.ToString(Convert.ToDouble(el1.Text) - Convert.ToDouble(el2.Text));
                el1.Text = "";
                el2.Text = "";
            }

            if (op == '*')
            {
                result.Text = Convert.ToString(Convert.ToDouble(el1.Text) * Convert.ToDouble(el2.Text));
                el1.Text = "";
                el2.Text = "";
            }

            if (op == '/')
            {
                result.Text = Convert.ToString(Convert.ToDouble(el1.Text) / Convert.ToDouble(el2.Text));
                el1.Text = "";
                el2.Text = "";
            }
        }
    }
}
