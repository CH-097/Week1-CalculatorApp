
// int variable stores the first number 
Console.WriteLine("Enter the first number followed by the Enter key: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()); //Convert the string input to a 32 bit integer value


// int variable stores the second number 
Console.WriteLine("Enter the second number followed by the Enter key: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//perform calculation
int result = firstNumber + secondNumber;

//output answer to console
Console.WriteLine("The result of adding {0} and {1}  is {2}", firstNumber, secondNumber, result); //{o} is a placeholder for the result variable


