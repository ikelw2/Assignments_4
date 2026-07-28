using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4_2_1.Models
{
    internal interface ICalculator
    {
        double Add(double x, double y);
        double Subtract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
    }
}
