void CalculatorApp()
{
    //declare variables
    int firstNumber, secondNumber, result, choice = 0;

    // int variable stores the first number 
    Console.WriteLine("Enter the first number followed by the Enter key: ");
    firstNumber = Convert.ToInt32(Console.ReadLine()); //Convert the string input to a 32 bit integer value


    // int variable stores the second number 
    Console.WriteLine("Enter the second number followed by the Enter key: ");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    //use loop to make relevant decision
    //perform calculation based on user input
    Console.WriteLine("What arithmetic operation would you like from the following list:\n" +
        "1 - Add\n" +
        "2 - Subtract\n" +
        "3 - Divide\n" +
        "4 - Multiply");

    //get user input for choice, and convert to integer
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} gives {result}");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {secondNumber} from {firstNumber} gives {result}");
    }
    else if (choice == 3)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} by {secondNumber} gives {result}");
    }
    else if (choice == 4)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} and {secondNumber} gives {result}");
    }
    else 
    {
        Console.WriteLine("You did not select a valid number. Please try again");
    }
}

    //Console.WriteLine("What arithmetic operation would you like to perform? (Enter +, -, *, /): ");

    CalculatorApp();
//call the CalculatorApp method to run the calculator application
