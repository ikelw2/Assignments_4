using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4_2_1.Models
{
    internal class MyMath : ICalculator
    {
        public MyMath() { }
        public double Add(double x, double y) { return x + y; }
        public double Subtract(double x, double y) { return x - y; }
        public double Multiply(double x, double y) { return x * y; }
        public double Divide(double x, double y) 
        {
            if ((y < 0.000000001) && (y > -0.000000001)) // handle divide-by-zero
            {
                return 0.0;
            }
            // otherwise return ordinary result
            return x / y; 
        }

    }
}
