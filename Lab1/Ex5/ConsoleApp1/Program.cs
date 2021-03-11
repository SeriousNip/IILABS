using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements for which to compute the mean");

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }

            double aritmMean=0;
            for (int i = 0; i < n; i++)
            {
                aritmMean = aritmMean + arr[i];
            }

            aritmMean = aritmMean / n;
            Console.WriteLine("Media Aritmetica este: " + aritmMean);

            double geomMean = 1;
            for (int i = 0; i < n; i++)
            {
                geomMean = geomMean * arr[i];
            }

            geomMean = Math.Sqrt(geomMean);

            Console.WriteLine("Media Geometrica este: " + geomMean);

        }
    }
}
