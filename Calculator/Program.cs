using Calculator;

Result firstResult = new();
Result secondResult = new();
Result memoryValue = new();

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
            }

            Result addResult = Calculations.Add(firstResult.Value, secondResult.Value);
            Console.WriteLine($"Sum: {addResult.Value}");

            break;
        case "2":
            break;
        case "3":
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
