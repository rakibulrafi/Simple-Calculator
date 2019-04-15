using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceCalculator
{
    internal class CalculatorFacade
    {
        string UserInput;

        InteractWithUser myInteractor = new InteractWithUser();
        InputChecker myInputChecker = new InputChecker();
        Calculator myCalculator = new Calculator();

        public CalculatorFacade() {
        }
            internal void RunCalculator()
            {
                UserInput = myInteractor.GetUserInput();
                if (myInputChecker.ValidInput(UserInput))
                {
                    string answer = myCalculator.DoOperation(UserInput);
                    myInteractor.GiveAnswer(answer);
                }
                else
                {
                    myInteractor.TellUserWhatWrong(myInputChecker.ErrorMessage);
                }
            }
        }
    }
