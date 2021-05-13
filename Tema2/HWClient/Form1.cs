using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWClient
{
    public partial class Form1 : Form
    {
        HWClient.ServiceReference1.WebService1SoapClient service = new HWClient.ServiceReference1.WebService1SoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> names = service.getAllNames();
            listBox1.DataSource = names;
            List<string> price = service.getAllPrices();
            listBox2.DataSource = price;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            service.updatePrice(listBox1.SelectedItem.ToString(), Convert.ToInt32(textBox1.Text));
            List<string> names = service.getAllNames();
            listBox1.DataSource = names;
            List<string> price = service.getAllPrices();
            listBox2.DataSource = price;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> names = service.getAllNames();
            listBox1.DataSource = names;
            List<string> price = service.getAllPrices();
            listBox2.DataSource = price;
        }
    }
}
