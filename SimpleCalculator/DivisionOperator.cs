using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace AdvanceCalculator
{
     class DivisionOperator:MathOperator 
    {
        

        public override int MathOperation(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}