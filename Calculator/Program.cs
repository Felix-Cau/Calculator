using Calculator;
using System.Windows.Markup;

Result firstUserValue = new();
Result secondUserValue = new();
Result calculationResult = new();
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
            firstUserValue = UserInputHandler.GetUserInput();
            if (firstUserValue.Message != null)
            {
                Console.WriteLine(firstUserValue.Message);
                break;
            }

            UserInputHandler.AskForUserInput();
            secondUserValue = UserInputHandler.GetUserInput();
            if (secondUserValue.Message != null)
            {
                Console.WriteLine(secondUserValue.Message);
                break;
            }

            calculationResult = Calculations.Add(firstUserValue.Value, secondUserValue.Value);
            Console.WriteLine($"Sum: {calculationResult.Value}");
            memory.Value = calculationResult.Value;
            MenuHandler.ClickToContinue();

            bool keepAddGoing = true;

            do
            {
                MenuHandler.SubMenu();
                string userAddSubSelection = Console.ReadLine();

                switch (userAddSubSelection)
                {
                    case "1":
                        Console.Clear();
                        UserInputHandler.AskForUserInput();
                        firstUserValue = UserInputHandler.GetUserInput();
                        if (firstUserValue.Message != null)
                        {
                            Console.WriteLine(firstUserValue.Message);
                            break;
                        }

                        calculationResult = Calculations.Add(memory.Value, firstUserValue.Value);
                        Console.WriteLine($"Sum: {calculationResult.Value}");
                        memory.Value = calculationResult.Value;
                        MenuHandler.ClickToContinue();
                        break;
                    case "2":
                        Console.Clear();
                        UserInputHandler.AskForUserInput();
                        firstUserValue = UserInputHandler.GetUserInput();
                        if (firstUserValue.Message != null)
                        {
                            Console.WriteLine(firstUserValue.Message);
                            break;
                        }

                        calculationResult = Calculations.Subtract(memory.Value, firstUserValue.Value);
                        Console.WriteLine($"Sum: {calculationResult.Value}");
                        memory.Value = calculationResult.Value;
                        MenuHandler.ClickToContinue();
                        break;
                    case "3":
                        Console.Clear();
                        UserInputHandler.AskForUserInput();
                        firstUserValue = UserInputHandler.GetUserInput();
                        if (firstUserValue.Message != null)
                        {
                            Console.WriteLine(firstUserValue.Message);
                            break;
                        }

                        calculationResult = Calculations.Multiply(memory.Value, firstUserValue.Value);
                        Console.WriteLine($"Sum: {calculationResult.Value}");
                        memory.Value = calculationResult.Value;
                        MenuHandler.ClickToContinue();
                        break;
                    case "4":
                        Console.Clear();
                        UserInputHandler.AskForUserInput();
                        firstUserValue = UserInputHandler.GetUserInput();
                        if (firstUserValue.Message != null)
                        {
                            Console.WriteLine(firstUserValue.Message);
                            break;
                        }

                        calculationResult = Calculations.Divide(memory.Value, firstUserValue.Value);
                        if (calculationResult.Message != null)
                        {
                            Console.WriteLine(calculationResult.Message);
                            break;
                        }
                        Console.WriteLine($"Sum: {calculationResult.Value}");
                        memory.Value = calculationResult.Value;
                        MenuHandler.ClickToContinue();
                        break;
                    case "0":
                        keepAddGoing = false;
                        break;
                    default:
                        MenuHandler.InvalidMenuOperation();
                        break;
                }
            } while ( keepAddGoing == true );

            break;
        case "2":
            Console.Clear();
            UserInputHandler.AskForUserInput();
            firstUserValue = UserInputHandler.GetUserInput();
            if (firstUserValue.Message != null)
            {
                Console.WriteLine(firstUserValue.Message);
                break;
            }

            UserInputHandler.AskForUserInput();
            secondUserValue = UserInputHandler.GetUserInput();
            if (secondUserValue.Message != null)
            {
                Console.WriteLine(secondUserValue.Message);
                break;
            }

            calculationResult = Calculations.Subtract(firstUserValue.Value,secondUserValue.Value);
            Console.WriteLine($"Sum: {calculationResult.Value}");
            memory.Value = calculationResult.Value;
            MenuHandler.ClickToContinue();

            break;
        case "3":
            Console.Clear();
            UserInputHandler.AskForUserInput();
            firstUserValue = UserInputHandler.GetUserInput();
            if (firstUserValue.Message != null)
            {
                Console.WriteLine(firstUserValue.Message);
                break;
            }

            UserInputHandler.AskForUserInput();
            secondUserValue = UserInputHandler.GetUserInput();
            if (secondUserValue.Message != null)
            {
                Console.WriteLine(secondUserValue.Message);
                break;
            }

            calculationResult = Calculations.Multiply(firstUserValue.Value, secondUserValue.Value);
            Console.WriteLine($"Sum: {calculationResult.Value}");
            memory.Value = calculationResult.Value;
            MenuHandler.ClickToContinue();

            break;
        case "4":
            Console.Clear();
            UserInputHandler.AskForUserInput();
            firstUserValue = UserInputHandler.GetUserInput();
            if (firstUserValue.Message != null)
            {
                Console.WriteLine(firstUserValue.Message);
                break;
            }

            UserInputHandler.AskForUserInput();
            secondUserValue = UserInputHandler.GetUserInput();
            if (secondUserValue.Message != null)
            {
                Console.WriteLine(secondUserValue.Message);
                break;
            }

            calculationResult = Calculations.Divide(firstUserValue.Value, secondUserValue.Value);
            if (calculationResult.Message != null)
            {
                Console.WriteLine(calculationResult.Message);
                break;
            }
            Console.WriteLine($"Sum: {calculationResult.Value}");
            memory.Value = calculationResult.Value;
            MenuHandler.ClickToContinue();

            break;
        case "0":
            keepGoing = false;
            Console.Clear();
            break;
        default:
            MenuHandler.InvalidMenuOperation();
            break;
    }
} while (keepGoing == true);
