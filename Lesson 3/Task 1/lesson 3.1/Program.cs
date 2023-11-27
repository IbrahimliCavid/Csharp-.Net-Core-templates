// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter first number");
float firstNum = float.Parse(Console.ReadLine());
Console.WriteLine("Please enter first number");
float secondNum = float.Parse(Console.ReadLine());

float result = (firstNum / secondNum);
Console.WriteLine($"Result: {firstNum} : {secondNum} = {result}");


Console.ReadLine();
