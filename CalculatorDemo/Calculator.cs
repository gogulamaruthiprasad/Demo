using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Substract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }
        public int Multiply(int num1, int num2)
        {
            // To trace error while testing,  writing + operator instead of * operator.
            return num1 * num2;
        }
        public string getFullName(string fName, string mName, string lName)
        {
            return string.Concat(fName + " " + mName + " " + lName);

        }

        public string getFullName(string fName)
        {
            return fName;

        }
    }
}
