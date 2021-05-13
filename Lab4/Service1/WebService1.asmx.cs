using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service1
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

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double F2C(double F)
        {
            return ((F - 32) * 5) / 9;
        }

        [WebMethod]
        public double C2F(double C)
        {
            return 1.8 * C + 32;
        }

        [WebMethod]
        public List<string> ListAll()
        {
            List<string> lista = new List<string>();

            lista.Add("Elementul 1");
            lista.Add("Elementul 2");
            lista.Add("Elementul 3");
            lista.Add("Elementul 4");
            lista.Add("Elementul 5");

            return lista;
        }
        [WebMethod]
        public string DateTimeDisplay()
        {
            return DateTime.Now.ToString();
        }

        [WebMethod]
        public double EuroToLei(double E)
        {
            double c = 4.9265;
            return (double)(E * c);
        }

        [WebMethod]
        public double LeiToEuro(double L)
        {
            double c = 4.9265;
            return (double)(L / c);
        }
    }
}
