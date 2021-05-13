using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientuAlaBlanaCuFormDianalaDinCareTrebe
{
    public partial class Form1 : Form
    {
        ClientuAlaBlanaCuFormDianalaDinCareTrebe.ServiceReference1.WebService1SoapClient service = new ClientuAlaBlanaCuFormDianalaDinCareTrebe.ServiceReference1.WebService1SoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "TIME: " + service.DateTimeDisplay();
            List<string> lista = new List<string> { };
            lista = service.ListAll();
            listBox1.DataSource = lista;
            Timer timer1 = new Timer();
            timer1.Interval = (10 * 100); 
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // c2f
            double x = Convert.ToDouble(textBox1.Text);
            textBox3.Text = service.C2F(x).ToString();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // f2c
            double x = Convert.ToDouble(textBox2.Text);
            textBox3.Text = service.F2C(x).ToString();
            textBox2.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                double euro2 = Convert.ToDouble(textBox5.Text);
                textBox4.Text = service.EuroToLei(euro2).ToString();
            }
            else
            {
                textBox4.Clear();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "TIME: "+ service.DateTimeDisplay();
        }
    }
}
