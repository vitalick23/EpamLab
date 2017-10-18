using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculator
    {
        public static double Addition(double first, double second)
        {
            return first + second;
        }

        public static double Multiplication(double first, double second)
        {
            return first * second;
        }

        public static double Subtraction(double first, double second)
        {
            return first - second;
        }

        public static double Division(double first, double second)
        {
            return first / second;
        }
    }
}
