using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCalculator
{
   public class Calculator
    {
        
        char[] delimiters = new char[] { '+', '-', '*', '/', '^' };
        List<int> numbersFromUser = new List<int>();
        char _operationSign;
        OperatorFactory myFactory = new OperatorFactory();

        public char OperationSign
        {
            get
            {
                return _operationSign;
            }
            set
            {
                if (delimiters.Contains(value))
                {
                    _operationSign = value;
                }
                else
                {
                    throw new Exception("Not a valid operation.  Must be +,-,*,/,^.");
                }
            }

        }
        public string Answer { get; set; }

        public string DoOperation(string userInput)
        {
            AssignFirstAndSecondNumber(userInput, numbersFromUser);
            GetOperation(userInput);
            MathOperator operatorToUse = myFactory.getMathOperator(OperationSign);
            int answer = operatorToUse.MathOperation(numbersFromUser[0], numbersFromUser[1]); ;
            return answer.ToString();
        }

        private void AssignFirstAndSecondNumber(string userInput, List<int> returnlist)
        {
            string[] numbers = userInput.Split(delimiters);
            for(int i = 0; i < numbers.Length; i++)
            {
                int numberToAdd = 0;
                if((int.TryParse(numbers[i],out numberToAdd)))
                {
                    returnlist.Add(numberToAdd);
                }
            }

        }

        public void GetOperation(string stringToCheck)
        {
            foreach(char letter in stringToCheck)
            {
                if (delimiters.Contains(letter))
                {
                    OperationSign = letter;
                }
            }
        }
        
    }
}
