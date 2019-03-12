using CalculatorDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Maruthi";
            string mname = "Prasad";
            string lname = "Gogula";

            var calculator = new Calculator();

            string result = calculator.getFullName(fname, mname, lname);
        }
    }
}
