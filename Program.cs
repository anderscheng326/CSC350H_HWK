/**
Console.WriteLine("start new branch for part3-challenge project");

UNIT 3 - Create and test method
**/


Console.WriteLine("Generating random numbers: ");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random rnd = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{rnd.Next(1,100)} ");
    }
    Console.WriteLine();
}

