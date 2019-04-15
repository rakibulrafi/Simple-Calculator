using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceCalculator
{
    public class OperatorFactory
    {
        public MathOperator getMathOperator(char operationSign)
        {
        switch(operationSign)
            {
                case '+':
                    return new AdditionOpearator();
                case '-':
                    return new SubtractionOperator();
                case '*':
                    return new MultiplicationOperator();
                case '/':
                    return new DivisionOperator();
                case '^':
                    return new ExponentialOperator();
                default:
                 return null;
            
           }
        }
    }
}
