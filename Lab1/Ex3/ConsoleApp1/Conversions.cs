using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Conversions
    {
        double n;
        public Conversions(double num)
        {
            n = num;
        }

        public double c2f()
        {
            double res;
            res = n * 9 / 5;
            res = res + 32;
            return res;
        }
        public double f2c()
        {
            double res;
            res = n - 32;
            res = res * 5 / 9;
            return res;
        }
    }
}
