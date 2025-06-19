double num1 = 0, num2 = 0, result = 0;

while (true)
{
    Console.Clear();
    Console.Write("Please enter first number: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Please enter second number: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Please enter an operator (+, -, *, /): ");
    char op = Console.ReadKey().KeyChar;

    switch (op)
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
            result = num2 != 0 ? num1 / num2 : 0;
            break;

        default:
            Console.WriteLine("\nInvalid operator!");
            result = 0;
            break;
    }

    Console.WriteLine($"\nResult: {result}");
    Console.WriteLine("Press any key to continue or 'q' to quit.");
    if (Console.ReadKey().KeyChar == 'q')
    {
        break;
    }
}