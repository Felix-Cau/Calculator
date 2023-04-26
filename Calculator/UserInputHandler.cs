using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class UserInputHandler
    {
        public static void AskForUserInput()
        {
            Console.WriteLine("Enter a value:");
        }

        public static Result GetUserInput()
        {
            Result result = new();
            string userInputString = Console.ReadLine();

            if (double.TryParse(userInputString, out double parsedValue))
            {
                result.Value = parsedValue;
                return result;
            }
            result.Message = MessageHandler.NoInput;
            return result;
        }
    }
}
