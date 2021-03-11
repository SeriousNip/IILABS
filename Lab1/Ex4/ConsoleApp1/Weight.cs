using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Weight
    {
        double[] genderCoef;
        int height, age;
    
        public Weight(double[] arr, int h, int a)
        {
            genderCoef = arr;
            height = h;
            age = a;
        }

        public double compWeight()
        {
            double res;
            res = (height - 100 - ((height - 150) / genderCoef[0])) + ((age - 20) / genderCoef[1]);
            return res;
        }
    }
}
