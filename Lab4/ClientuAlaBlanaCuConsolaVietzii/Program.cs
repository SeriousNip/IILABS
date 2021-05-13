using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientuAlaBlanaCuConsolaVietzii
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientuAlaBlanaCuConsolaVietzii.ServiceReference1.WebService1SoapClient service = new ClientuAlaBlanaCuConsolaVietzii.ServiceReference1.WebService1SoapClient();


            while (true)
            {
                Console.WriteLine("1. C2F");
                Console.WriteLine("2. F2C");
                Console.WriteLine("3. Ron2Euro");
                Console.WriteLine("4. Euro2Ron");
                Console.WriteLine("5. Item List");
                Console.WriteLine("6. Time");
                Console.WriteLine("7. Exit");
                int caz;
                caz = Convert.ToInt32(Console.ReadLine());
                switch (caz)
                {
                    case 1:
                        double x;
                        x = Convert.ToDouble(Console.ReadLine());
                        double f = service.C2F(x);
                        Console.WriteLine(f);
                        break;
                    case 2:
                        double y;
                        y = Convert.ToDouble(Console.ReadLine());
                        double c = service.F2C(y);
                        Console.WriteLine(c);
                        break;
                    case 3:
                        double lei1;
                        lei1 = Convert.ToDouble(Console.ReadLine());
                        double euro1 = service.LeiToEuro(lei1);
                        Console.WriteLine(euro1);
                        break;
                    case 4:
                        double euro2;
                        euro2 = Convert.ToDouble(Console.ReadLine());
                        double lei2 = service.EuroToLei(euro2);
                        Console.WriteLine(lei2);
                        break;
                    case 5:
                        List<string> lista = new List<string> { };
                        lista = service.ListAll();
                        lista.ForEach(Console.WriteLine);
                        break;
                    case 6:
                        String date = service.DateTimeDisplay();
                        Console.WriteLine(date);
                        break;
                    case 7:
                        return;
                }
            }
        }
    }
}
