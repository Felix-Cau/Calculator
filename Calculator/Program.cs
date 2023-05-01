using Calculator;

Result firstResult = new();
Result secondResult = new();
Result memory = new();

bool keepGoing = true;

do
{
    MenuHandler.MainMenu();
    string userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            Console.Clear();
            UserInputHandler.AskForUserInput();
            firstResult = UserInputHandler.GetUserInput();
            if (firstResult.Message != null)
            {
                Console.WriteLine(firstResult.Message);
                break;
            }

            UserInputHandler.AskForUserInput();
            secondResult = UserInputHandler.GetUserInput();
            if (secondResult.Message != null)
            {
                Console.WriteLine(secondResult.Message);
                break;
            }

            Result addResult = Calculations.Add(firstResult.Value, secondResult.Value);
            Console.WriteLine($"Sum: {addResult.Value}");
            memory.Value = addResult.Value;
            MenuHandler.ClickToContinue();

            break;
        case "2":
            Console.Clear();
            UserInputHandler.AskForUserInput();
            firstResult = UserInputHandler.GetUserInput();
            if (firstResult.Message != null)
            {
                Console.WriteLine(firstResult.Message);
                break;
            }

            UserInputHandler.AskForUserInput();
            secondResult = UserInputHandler.GetUserInput();
            if (secondResult.Message != null)
            {
                Console.WriteLine(secondResult.Message);
                break;
            }

            Result subtractResult = Calculations.Subtract(firstResult.Value,secondResult.Value);
            Console.WriteLine($"Sum: {subtractResult.Value}");
            memory.Value = subtractResult.Value;
            MenuHandler.ClickToContinue();

            break;
        case "3":
            Console.Clear();
            UserInputHandler.AskForUserInput();
            firstResult = UserInputHandler.GetUserInput();
            if (firstResult.Message != null)
            {
                Console.WriteLine(firstResult.Message);
                break;
            }

            UserInputHandler.AskForUserInput();
            secondResult = UserInputHandler.GetUserInput();
            if (secondResult.Message != null)
            {
                Console.WriteLine(secondResult.Message);
                break;
            }

            Result multiplyResult = Calculations.Multiply(firstResult.Value, secondResult.Value);
            Console.WriteLine($"Sum: {multiplyResult.Value}");
            memory.Value = multiplyResult.Value;
            MenuHandler.ClickToContinue();

            break;
        case "4":
            break;
        case "0":
            keepGoing = false;
            Console.Clear();
            break;
        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(MessageHandler.InvalidOperation);
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }


} while (keepGoing == true);
