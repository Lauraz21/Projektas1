using System.Diagnostics.CodeAnalysis;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(@"   _________   ");
Console.WriteLine(@"_ /_|_____|_\ _");
Console.WriteLine(@"  '. \   / .'  ");
Console.WriteLine(@"    '.\ /.'    ");
Console.WriteLine(@"      '.'      ");

Random random = new Random();
int numberToGuess = random.Next(51);
Console.WriteLine("Press space button to start");
Console.ReadKey();
Console.WriteLine(".............................");
Console.WriteLine("GUESS ANY NUMBER BETWEEN 0-50");
while (true)
{

    int number = Convert.ToInt32(Console.ReadLine());

    if (number >= (numberToGuess - 2) && (number < numberToGuess))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The number is a little bit higher");
    }
    else if (number < numberToGuess)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("The number is higher");
    }

    else if (number <= (numberToGuess + 2) && (number > numberToGuess))
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("The number is a little bit lower");
    }
    else if (number > numberToGuess)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("The number is lower");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Correct!");
        return;
    }
}

