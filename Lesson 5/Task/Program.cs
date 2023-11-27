// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("The first natural numbers: ");

for (int i = 1; i <= 10; i++)
{
  
    Console.WriteLine(i);
}


Console.ReadLine();
--------------------------
    
using System.Collections;

Console.WriteLine("The sum of first 20 odd natural numbers: ");

ArrayList numbers = new ArrayList();
int sum = 0;    

for (int i = 1; i < 20; i+=2)
{
    numbers.Add(i);  
}
foreach (string  item in numbers)
{
    sum += int.Parse(item);
}
Console.WriteLine(sum);
Console.ReadLine();
----------------------------------




using System.Collections;

Console.WriteLine("Please enter the count of numbers");

float count = float.Parse(Console.ReadLine());

ArrayList numbers = new ArrayList();
float sum = 0;    

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Please enter {i+1}. number");
    numbers.Add(Console.ReadLine());
}

foreach (string  item in numbers)
{
    sum += float.Parse(item);
}
float numbersCount = Convert.ToSingle(numbers.Count);

float numericalAvarage = sum / numbersCount;

Console.WriteLine($"The numerical average of the numbers you entered:{numericalAvarage}");






Console.ReadLine(); 

------------------------------

Console.WriteLine("Please enter the count of multiplication table: ");

int count = int.Parse(Console.ReadLine()) ;


for (int i = 1; i <= count; i++)
{
    for (int j = 1; j <=10; j++)
    {
        int result = i * j;
        Console.WriteLine($"{i}*{j} = {result}");
    }
   
}

Console.ReadLine();


// 1 2 3
// 1*1 1*2 1*3
// 2*1 2*2 2*3
// 3*1 3*2 3*3

----------------------------
  


//*
//**
//***




Console.WriteLine("Please enter the number of lines to create a pattern like  right triangle using a star: ");

int count = int.Parse(Console.ReadLine());
  
    string a = "*";

    for (int i = 0; i < count; i++)
    {
    Console.WriteLine(a);

       a += "*";
   
    }
   
Console.ReadLine();

--------------------------------------- 


Console.Write("Enter count of rows : ");
int count = int.Parse(Console.ReadLine());

int k = 1;

for (int i = 0; i < count; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("{0} ", k++);
    }
    Console.WriteLine();
}
 --------------------------------------

using System.Collections;

Console.WriteLine("Whic number series do you want? Please enter a number from 1-9: ");
string number = Console.ReadLine();
Console.WriteLine("Please enter the number from 1-9 of numbers in the series: ");
int count = int.Parse(Console.ReadLine());
ArrayList  series = new ArrayList();
string numberSeries = number;
int sum = 0;


for (int i = 0; i < count; i++)
{
    series.Add(numberSeries);
    numberSeries += number; 
     sum += Convert.ToInt32(series[i]); 
}

Console.WriteLine(sum);

------------------------------------------------

using System.Collections;

Console.WriteLine("Please enter a number: ");
int count = int.Parse(Console.ReadLine());

bool isPrime = true;

for (int i = 2; i <= count; i++)
{

    for (int j = 2; j <= count ; j++)
    {
        if(i%j == 0 && i != j)
        {
          isPrime = false;
            break;
        }

        
    }
    if(isPrime)
        {
            Console.WriteLine(i);
        }
        isPrime = true;
}



using System.Collections;
ArrayList primeNumbers = new ArrayList();

bool isPrime = true;

for (int i = 2; i <= 100; i++)
{

    for (int j = 2; j <= 100; j++)
    {
        if (i % j == 0 && i != j)
        {
            isPrime = false;
            break;
        }


    }
    if (isPrime)
    {
        primeNumbers.Add(i);
    }
    isPrime = true;
}

// To check whether a number can be express as sum of two prime numbers.
Console.WriteLine("Please enter a number from 1-100 for sum of two prime numbers: ");
int number = int.Parse(Console.ReadLine());
for (int i = 0;  i < primeNumbers.Count; i++)
{
    for (int j = 1;  j < primeNumbers.Count; j++)
    {
        int firstNumber = Convert.ToInt32( primeNumbers[i]);
        int secondNumber = Convert.ToInt32(primeNumbers[j]);
        if (isPrime && firstNumber + secondNumber == number)
        {
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, number);
     
        }
     
        
    }
}
----------------------------------------------------------------


Console.WriteLine("Please enter a number: ");
string number = Console.ReadLine();

bool isTrue = true;

for (int i = 0; i < number.Length / 2; i++)
{
    if ( number[i] != number[number.Length - i - 1])
    {
     isTrue = false;
        break;
    }
}

if ( isTrue)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("false");
}
*/






















