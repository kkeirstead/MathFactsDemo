// Basic calculator app
Console.WriteLine("Welcome to the Basic Calculator App!");

bool keepRunning = true;
while (keepRunning)
{
    // Get first number
    Console.Write("Enter first number: ");
    string firstInput = Console.ReadLine();
    if (!int.TryParse(firstInput, out int num1))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        continue;
    }

    // Get second number
    Console.Write("Enter second number: ");
    string secondInput = Console.ReadLine();
    if (!int.TryParse(secondInput, out int num2))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        continue;
    }

    // Get operator
    Console.Write("Enter operator (+, -, *, /): ");
    string op = Console.ReadLine();
    
    if (string.IsNullOrEmpty(op) || op.Length != 1)
    {
        Console.WriteLine("Invalid operator. Please enter +, -, *, or /");
        continue;
    }

    // Perform calculation
    int result = 0;
    bool validCalculation = true;
    
    switch (op[0])
    {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            result = num1 / num2;
            break;
        default:
            Console.WriteLine("Invalid operator. Please use +, -, *, or /");
            validCalculation = false;
            break;
    }

    if (validCalculation)
    {
        Console.WriteLine($"Result: {num1} {op[0]} {num2} = {result}");
    }

    // Ask to continue
    Console.Write("Do another calculation? (y/n): ");
    string answer = Console.ReadLine();
    if (string.IsNullOrEmpty(answer) || (answer.ToLower() != "y" && answer.ToLower() != "yes"))
    {
        keepRunning = false;
    }
}

Console.WriteLine("Thank you for using the calculator!");
