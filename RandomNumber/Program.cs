Random random = new Random();
double min = 0;
double max = 100;

do
{
    Console.Clear();
    Console.Write("Enter the minimum value (default 0): ");
    string minInput = Console.ReadLine();
    min = string.IsNullOrEmpty(minInput) ? 0 : Convert.ToDouble(minInput);

    Console.Write("Enter the maximum value (default 100): ");
    string maxInput = Console.ReadLine();
    max = string.IsNullOrEmpty(maxInput) ? 100 : Convert.ToDouble(maxInput);

    // Checks to make sure min is less than or equal max

    if (min >= max)
    {
        Console.WriteLine("Minimum value must be less than maximum value. Please try again.");
        Console.Write("Press any key to continue or 'q' to quit: ");
        continue;
    }

    Console.WriteLine("\nint: Integer Number");
    Console.WriteLine("double: Decimal Number\n");
    Console.Write("Enter a type: ");

    string type = Console.ReadLine().ToLower();
    if (type == "int")
    {
        int randomInt = random.Next((int)min, (int)max);
        Console.WriteLine($"Random Integer: {randomInt}");
    }
    else if (type == "double")
    {
        double randomDouble = random.NextDouble() * max;
        Console.WriteLine($"Random Double: {randomDouble}");
    }
    else
    {
        Console.WriteLine("Invalid type. Please enter 'int' or 'double'.");
    }

    Console.Write("Press any key to continue or 'q' to quit: ");
}
while (Console.ReadKey().KeyChar != 'q');