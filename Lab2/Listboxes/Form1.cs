using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listboxes
{
    public partial class Form1 : Form
    {

        string[] lst = File.ReadAllLines("list.txt");

        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i<lst.Length; i++)
            {
                listBox1.Items.Add(lst[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
