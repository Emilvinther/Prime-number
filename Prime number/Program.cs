Console.WriteLine("Tast et nummer");
int input = int.Parse(Console.ReadLine());

for (int i = 0; i < input; i++)
{
    bool IsPrime = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            IsPrime = false;
            
        }
    }

    if (IsPrime == true)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(i);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(i);
    }
}

Console.ReadKey();
