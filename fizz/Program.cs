// See https://aka.ms/new-console-template for more information
Console.WriteLine("Proyecto fizz buzz");

int i;

for (i = 1; i <= 100; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.WriteLine("Fizz Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz ");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzzz ");
    }
    Console.WriteLine(i);
}
