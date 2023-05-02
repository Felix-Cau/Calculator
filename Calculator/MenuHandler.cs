using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class MenuHandler
    {
        public static void MainMenu()
        {
            Console.WriteLine("What operation do you want to do?");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("0. Exit calculator");
            Console.WriteLine("Enter a number to select operation: ");
        }

        public static void SubMenu()
        {
            Console.WriteLine("Choose your next action.");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("0. Clear everything");
            Console.WriteLine("Enter a number to select operation: ");
        }

        public static void ClickToContinue()
        {
            Console.WriteLine("Click any button to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void InvalidMenuOperation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(MessageHandler.InvalidOperation);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
