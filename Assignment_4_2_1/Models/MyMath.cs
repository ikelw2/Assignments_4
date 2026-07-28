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
        public double Divide(double x, double y) { return x / y; }

    }
}
