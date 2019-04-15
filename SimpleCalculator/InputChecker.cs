using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceCalculator
{
   public class InputChecker
    {
        List<string> listOfIntegers;
        public List<char> ListOfOperators;
        string _ErrorMessage;

        public string ErrorMessage
        {
            get { return _ErrorMessage ?? "No Error"; }

            set { _ErrorMessage = value; }
        }
        public InputChecker()
        {
            listOfIntegers= new List<string>() {"0", "1","2","3","4","5","6","7","8","9"};
            ListOfOperators = new List<char>() { '+','-','*','/','^'};

        }
        public bool ValidInput(string inputString)
        {
            if (NoSpaces(inputString) && EitherNumberOrOperator(inputString) && OnlyOneOperator(inputString) && CorrectOrder(inputString) && !String.IsNullOrEmpty(inputString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool NoSpaces(string inputString)
        {
            int numberOfWhitespaces = 0;

            foreach (char letter in inputString)
            {
                if (char.IsWhiteSpace(letter))
                {
                    numberOfWhitespaces++;
                }
            }

            if (numberOfWhitespaces > 0)
            {
                ErrorMessage = "Please don't include spaces.";
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool EitherNumberOrOperator(string inputString)
        {
            int counter = 0;

            foreach (char character in inputString)
            {
                if (Char.IsNumber(character) || ListOfOperators.Contains(character))
                {
                    counter++;
                }
            }

            if (counter == inputString.Length)
            {
                return true;
            }
            else
            {
                ErrorMessage = "Please include only numbers and one of the five operators.";
                return false;
            }
        }
        public bool OnlyOneOperator(string inputString)
        {
            int counter = 0;

            foreach (char character in inputString)
            {
                if (ListOfOperators.Contains(character))
                {
                    counter++;
                }
            }

            if (counter > 1)
            {
                ErrorMessage = "Please include only one operator";
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool isANumber(string stringToCheck)
        {
            int result;

            return int.TryParse(stringToCheck, out result);
        }

        public bool CorrectOrder(string inputString)
        {
            char[] delimiterCharacters = ListOfOperators.ToArray();
            string[] numbers = inputString.Split(delimiterCharacters);

            if (numbers.Count() == 2 && isANumber(numbers[0]) && isANumber(numbers[1]))
            {
                return true;
            }
            else
            {
                ErrorMessage = "Please enter the input as: Number Operator Number";
                return false;
            }
        }

    }
}
