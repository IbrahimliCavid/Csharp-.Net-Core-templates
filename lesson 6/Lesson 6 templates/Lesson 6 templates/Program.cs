using System.Collections;

//int count = int.Parse(Console.ReadLine());  
//ArrayList numbers = new ArrayList();    
//numbers.Add(0);
//numbers.Add(1);

//for (int i = 0; i < count; i++)
//{
//    int fibaronci = Convert.ToInt32(numbers[i]) + Convert.ToInt32(numbers[i + 1]);
//    numbers.Add(fibaronci);
//    Console.WriteLine(numbers[i]);

//}

//-----------------------------------

string number = Console.ReadLine();
string numberElement ;
int sum = 0;



for (int i = 0; i < number.Length; i++)
{
    numberElement = number[i].ToString();
    sum += int.Parse(numberElement);
    Console.WriteLine(numberElement);
    Console.WriteLine(number[i]); 
}

Console.WriteLine(sum); 


//string sentence = Console.ReadLine();
//int countSpaces = 0;

//for (int i = 0; i < sentence.Length; i++)
//{
//    if (sentence[i] == ' ')
//    {
//        countSpaces++;
//    }
//}

//Console.WriteLine(countSpaces);   