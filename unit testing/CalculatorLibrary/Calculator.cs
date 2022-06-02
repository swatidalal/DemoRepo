using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
     public class Calculator : ICalculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Substract(int num1, int num2)
        {
            return (num2 - num1);
        }
        public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

        public static int mod(int num1, int num2)
        {
            return num2 % num1;
        }
    }
}
