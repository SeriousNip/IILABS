using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many number from the fibonacci string do you want?");
            int num=Convert.ToInt32(Console.ReadLine());
            int f0 = 0;
            int f1 = 1;
            Console.WriteLine("These are the numbers:");
            Console.WriteLine(f0);
            Console.WriteLine(f1);
            for(int i = 1; i <= num; i++)
            {
                int fnext = f1 + f0;
                f0 = f1;
                f1 = fnext;
                Console.WriteLine(fnext);
            }
        }
    }
}
