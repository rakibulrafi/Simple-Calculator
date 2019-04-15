using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace AdvanceCalculator
{
    class InteractWithUser
    {
        public string GetUserInput()
        {
            Console.WriteLine("Enter your math operation.  One operation only.  No spaces.  Please stick to positive integers and 0 and these operations: +, -, *, /, ^.");

            return Console.ReadLine();
        }

        public void TellUserWhatWrong(string errorMessage)
        {
            Console.WriteLine("Sorry what you entered won't work out.  Here's why: {0}", errorMessage);
        }
        public void GiveAnswer(string answer)
        {
            Console.WriteLine("Here is the answer to your operation: {0}", answer);
        }

    }
}
