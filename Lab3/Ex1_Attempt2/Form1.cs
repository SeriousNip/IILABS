using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ex1_Attempt2
{
    public partial class Form1 : Form
    {
        SqlConnection MyConn = new SqlConnection();
        DataSet dsFac;
        DataSet dsUniv;

        public Form1()
        {
            InitializeComponent();
            MyConn.ConnectionString = @"Data Source=DESKTOP-VMATF7P\WINCC;Initial Catalog=Ex1;Integrated Security=True";
            MyConn.Open();
            dsUniv = new DataSet();
            dsFac = new DataSet();

            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", MyConn);
            daUniv.Fill(dsUniv, "Universitati");
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", MyConn); 
            daFac.Fill(dsFac, "Facultati");

            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows) 
            { 
                String name = dr.ItemArray.GetValue(1).ToString(); 
                lb_Univ.Items.Add(name); 
            }
            MyConn.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lb_Fac_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lb_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Fac.Items.Clear();
            tb_Oras.Clear();
            int code = 0;
            String UnivSelected = lb_Univ.SelectedItem.ToString();
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    tb_Oras.Text = dr.ItemArray.GetValue(2).ToString();
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    tb_Cod.Text = code.ToString();
                }
            }

            foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
            {
                if (code == Convert.ToInt16(dr.ItemArray.GetValue(2)))
                {
                    String nameFac = dr.ItemArray.GetValue(1).ToString();
                    lb_Fac.Items.Add(nameFac);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyConn.ConnectionString = @"Data Source=DESKTOP-VMATF7P\WINCC;Initial Catalog=Ex1;Integrated Security=True";
            MyConn.Open();
            SqlCommand deletequery = new SqlCommand();
            deletequery.Connection = MyConn;
            int code1 = Convert.ToInt32(tb_Cod.Text);
            deletequery.CommandText = @"DELETE FROM Facultati WHERE Code = @code1";
            deletequery.Parameters.AddWithValue("@code1", code1);
            deletequery.ExecuteNonQuery();
            int code = Convert.ToInt32(tb_Cod.Text);
            deletequery.CommandText = @"DELETE FROM Universitati WHERE Code = @code";
            deletequery.Parameters.AddWithValue("@code", code);
            deletequery.ExecuteNonQuery();
            MyConn.Close();
            MessageBox.Show("Successful");
            lb_Fac.Items.Clear();
            lb_Univ.Items.RemoveAt(lb_Univ.SelectedIndex);
        }

        private void tb_Cod_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyConn.ConnectionString = @"Data Source=DESKTOP-VMATF7P\WINCC;Initial Catalog=Ex1;Integrated Security=True";
            MyConn.Open();
            SqlCommand updatequery = new SqlCommand();
            updatequery.Connection = MyConn;
            string oras = tb_Oras.Text;
            updatequery.CommandText = @"UPDATE Universitati SET City = @oras WHERE Code = @OldCode";
            updatequery.Parameters.AddWithValue("@oras", oras);
            updatequery.Parameters.AddWithValue("@OldCode", tb_Cod.Text);
            updatequery.ExecuteNonQuery();
            MyConn.Close();
            MessageBox.Show("Successful");
        }
    }
}
