using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Gender: (m/f)");
            char g = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Height in cm: ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Age: ");
            int a = Convert.ToInt32(Console.ReadLine());

            double[] arr=new double[] { };

            if (g == 'f')
            {
                arr = new double[] { 2.5, 6 };
            }else if (g == 'm')
            {
                arr = new double[] { 4, 4 };
            }
            else
            {
                Console.WriteLine("Gender is Invalid!");
                return;
            }

            Weight ctrl = new Weight(arr, h, a);

            double result = ctrl.compWeight();
            Console.WriteLine(result);
        }
    }
}
