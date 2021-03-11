using System;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number you want displayed in Farenheit and Celsius");
            double n = Convert.ToDouble(Console.ReadLine());

            Conversions con = new Conversions(n);

            Console.WriteLine("Your number from Farenheit to Celsius is:");
            Console.WriteLine(con.f2c());

            Console.WriteLine("Your number from Celsius to Farenheit is:");
            Console.WriteLine(con.c2f());

        }

        
    }
}
