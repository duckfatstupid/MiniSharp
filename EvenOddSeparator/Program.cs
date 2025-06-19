Console.Write("Enter how many numbers you want: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Numbers = new int[size];

for (int i = 0; i < Numbers.Length; i++)
{
    Console.Write($"Enter number #{i + 1}: ");
    Numbers[i] = Convert.ToInt32(Console.ReadLine());
}

// Even
Console.WriteLine("\nEven numbers:");
int totalEven = 0;
foreach (int Number in Numbers)
{
    if (Number % 2 == 0)
    {
        Console.Write(Number + " ");
        totalEven++;
    }
}

Console.WriteLine($"\n  Total even: {totalEven}");

// Odd
Console.WriteLine("\nOdd numbers:");
int totalOdd = 0;
foreach (int Number in Numbers)
{
    if (Number % 2 != 0)
    {
        Console.Write(Number + " ");
        totalOdd++;
    }
}

Console.WriteLine($"\n  Total odd: {totalOdd}");

Console.ReadKey();