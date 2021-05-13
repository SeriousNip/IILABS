using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ShopServer
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsShop;

        [WebMethod]
        public List<string> getAllNames()
        {
            myCon.ConnectionString = @"Data Source=DESKTOP-VMATF7P\WINCC;Initial Catalog=server;Integrated Security=True";
            myCon.Open();

            List<string> listaNume = new List<string> { };
            dsShop = new DataSet();

            SqlDataAdapter daShop = new SqlDataAdapter("SELECT * FROM shop", myCon);
            daShop.Fill(dsShop, "Shop");

            foreach (DataRow dr in dsShop.Tables["Shop"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listaNume.Add(name);

            }
            myCon.Close();
            return listaNume;

        }

        [WebMethod]
        public List<string> getAllPrices()
        {
            myCon.ConnectionString = @"Data Source=DESKTOP-VMATF7P\WINCC;Initial Catalog=server;Integrated Security=True";
            myCon.Open();

            List<string> listaNume = new List<string> { };
            dsShop = new DataSet();

            SqlDataAdapter daShop = new SqlDataAdapter("SELECT * FROM shop", myCon);
            daShop.Fill(dsShop, "Shop");

            foreach (DataRow dr in dsShop.Tables["Shop"].Rows)
            {
                String price = dr.ItemArray.GetValue(2).ToString();
                listaNume.Add(price);

            }
            myCon.Close();
            return listaNume;

        }

        [WebMethod]
        public void addItem(string name, int price)
        {
            myCon.ConnectionString = @"Data Source=DESKTOP-VMATF7P\WINCC;Initial Catalog=server;Integrated Security=True";
            myCon.Open();
            Random rnd = new Random();
            DataSet item = new DataSet();

            SqlCommand insert = new SqlCommand();
            insert.Connection = myCon;
            insert.CommandText = @"INSERT INTO Shop VALUES (@id, @name, @price)";
            insert.Parameters.AddWithValue("@id", rnd.Next(1000));
            insert.Parameters.AddWithValue("@name", name);
            insert.Parameters.AddWithValue("@price", price);

            insert.ExecuteNonQuery();
            myCon.Close();
        }

        [WebMethod]
        public void updatePrice(string name, int price)
        {
            myCon.ConnectionString = @"Data Source=DESKTOP-VMATF7P\WINCC;Initial Catalog=server;Integrated Security=True";
            myCon.Open();
            Random rnd = new Random();
            DataSet item = new DataSet();

            SqlCommand insert = new SqlCommand();
            insert.Connection = myCon;
            insert.CommandText = @"UPDATE Shop SET Pret=@price WHERE CAST(Nume as varchar(max))=@name";
            insert.Parameters.AddWithValue("@price", price);
            insert.Parameters.AddWithValue("@name", name);
            

            insert.ExecuteNonQuery();
            myCon.Close();
        }

    }
}
