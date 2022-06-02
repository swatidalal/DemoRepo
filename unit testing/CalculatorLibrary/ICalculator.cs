using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public interface ICalculator
    {
        int Add(int num1, int num2);
        int Substract(int num1, int num2);
        float Multiply(float num1, float num2);
        float Divide(float num1, float num2);

    }
}
