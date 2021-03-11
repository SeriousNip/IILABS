using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Operations
    {
        double n1, n2;
        public Operations(double num1, double num2)
        {
            n1 = num1;
            n2 = num2;
        }
        public double addition()
        {
            double r;
            r= n1 + n2;
            return r;
        }

        public double substraction()
        {
            double r;
            r = n1 - n2;
            return r;
        }

        public double multiplication()
        {
            double r;
            r = n1 * n2;
            return r;
        }

        public double division()
        {
            double r;
            r = n1 / n2;
            return r;
        }

    }
}
