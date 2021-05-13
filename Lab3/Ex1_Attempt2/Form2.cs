using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ex1_Attempt2
{
    public partial class Form2 : Form
    {
        SqlConnection MyConn = new SqlConnection();

        public Form2()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyConn.ConnectionString = @"Data Source=DESKTOP-VMATF7P\WINCC;Initial Catalog=Ex1;Integrated Security=True";
            MyConn.Open();
            DataSet maxId = new DataSet();
            string nume = textBox1.Text;
            string oras = textBox2.Text;
            int cod = Convert.ToInt16(textBox3.Text);
            SqlCommand insertquery = new SqlCommand();
            insertquery.Connection = MyConn;
            insertquery.CommandText = @"INSERT INTO Universitati VALUES (@id,@nume,@oras,@cod) ";
            insertquery.Parameters.AddWithValue("@id",9999);
            insertquery.Parameters.AddWithValue("@nume", nume);
            insertquery.Parameters.AddWithValue("@oras", oras);
            insertquery.Parameters.AddWithValue("@cod", cod);

            insertquery.ExecuteNonQuery();
            MyConn.Close();
            MessageBox.Show("Successful");
            this.Close();
        }
    }
}
