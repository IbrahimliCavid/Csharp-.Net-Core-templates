// See https://aka.ms/new-console-template for more information
//Write a C# program that takes 2 inputs form user respectively name and surname, and then print it as "NAME SURNAME" (both uppercase) in console

Console.WriteLine("Please enter first name:");
string firstName = Console.ReadLine();
string lastName = Console.ReadLine();

string fullName = $"{firstName} {lastName}";



Console.WriteLine($"User full name: {fullName.ToUpper()}");

Console.ReadLine();

