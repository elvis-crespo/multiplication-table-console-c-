

Console.WriteLine("\tMultiplication table");
Console.Write("Enter a number: ");
string? num = Console.ReadLine();
Multiplication(num);

static void Multiplication(string input)
{
    int counter = 1;
    for (int i = 1; i < 13; i++)
    {
        int value = counter++;
        Console.Write($"{value} * {input} = ");

        for (int j = 0; j < value; j++)
        {
            Console.Write($"{input}");
        }
        Console.WriteLine();
    }

    //int num = 12;
    //for (int i = 1; i <= num; i++)
    //{
    //    Console.WriteLine($"{num} * {i} = {num * i}");
    //}
}
