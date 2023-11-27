// See https://aka.ms/new-console-template for more information

char[] letter= new char[3];
    

Console.WriteLine("Enter the first letter:");
letter[0] = char.Parse(Console.ReadLine());
Console.WriteLine("Enter the second letter:");
letter[1] = char.Parse(Console.ReadLine());
Console.WriteLine("Enter the thrid letter:");
letter[2] = char.Parse(Console.ReadLine());

if (letter.Length == 3)
{

    Console.WriteLine($"{letter[2]}{letter[1]}{letter[0]}");
}






Console.ReadLine();