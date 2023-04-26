using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class MessageHandler
    {
        public static string NoInput => "Enter a valid value.";
        public static string Error => "Something went wrong, try again.";
        public static string CantDivideByZero => "You can't divide by zero.";

        public static string InvalidOperation => "Invalid operation.";

        private static string WelcomeMessage = @"\Welcome!\nThis is not the best calculator in the world. No, this is just a tribute!\n";

        public static void Welcome()
        {
            Console.WriteLine(WelcomeMessage);
        }
    }
}
