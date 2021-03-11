using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two real numbers");

            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());

            Operations oper = new Operations(n1,n2);
            Console.WriteLine("These are the results to the basic operations using your numbers: ");
            Console.WriteLine("Addition");
            Console.WriteLine(oper.addition());
            Console.WriteLine("Substraction");
            Console.WriteLine(oper.substraction());
            Console.WriteLine("Multiplication");
            Console.WriteLine(oper.multiplication());
            Console.WriteLine("Division");
            Console.WriteLine(oper.division());
        }
    }
}
