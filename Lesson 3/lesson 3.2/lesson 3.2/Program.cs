// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter sentence:");
string sentence = Console.ReadLine();

Console.WriteLine("Please search within the sentence:");

string filter = Console.ReadLine();

bool result = sentence.Contains(filter);

Console.WriteLine(result);






Console.ReadLine(); 
