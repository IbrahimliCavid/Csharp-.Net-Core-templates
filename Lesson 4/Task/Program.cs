// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Please enter  your brithday: ");
DateTime userBrithday = Convert.ToDateTime(Console.ReadLine());

var dayOfWeek = userBrithday.DayOfWeek;

Console.WriteLine($"Your brithday is {dayOfWeek}");

Console.ReadLine();

-----------------------------------------

Console.WriteLine("Please enter  your brithday: ");
DateTime nowDate = DateTime.Now;
DateTime userBrithday = Convert.ToDateTime(Console.ReadLine());

TimeSpan result = nowDate - userBrithday;


Console.WriteLine(result.Days);
Console.ReadLine();
--------------------------------------------------------

Console.WriteLine("Please add the numbers of days");

int nextDay = int.Parse(Console.ReadLine());   

DateTime nowDate = DateTime.Now;

DateTime result = nowDate.AddDays(nextDay);

Console.WriteLine(result.DayOfWeek);


Console.ReadLine(); 
--------------------------------

Console.WriteLine("Please enter day:");

int day = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter month:");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter year:");
int year = int.Parse(Console.ReadLine());
DateTime nowDate = DateTime.Now;

if (nowDate.Day == day && nowDate.Month == month && nowDate.Year == year)
{
Console.WriteLine("True");
}
else
{
    Console.WriteLine($"False because now date = {nowDate}");
}



Console.ReadLine();
---------------------------------------------------------------

Console.WriteLine("Please enter to day: ");
int day = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter to month: ");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter to month: ");
int year = int.Parse(Console.ReadLine());
DateTime pointedDate = Convert.ToDateTime($"{day}/{month}/{year}");
DateTime lastDayOfYear = Convert.ToDateTime($"{31}/ {12}/ {year}");


Console.WriteLine($"Format date: {pointedDate.Date.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Last day of year: {lastDayOfYear.Date.ToString("dd/MM/yyyy")}");





Console.ReadLine();

---------------------------------------------------------------------

Console.WriteLine("Please enter to day: ");
int day = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter to month: ");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter to month: ");
int year = int.Parse(Console.ReadLine());
DateTime pointedDate = Convert.ToDateTime($"{day}/{month}/{year}");

int lastDayOfWeek = day + 7 - Convert.ToInt32(pointedDate.DayOfWeek);
DateTime newDataTime = Convert.ToDateTime($"{lastDayOfWeek}/{month}/{year}");

Console.WriteLine($"The date you entered: {pointedDate.Date.ToString("dd/MM/yyyy")}");
Console.WriteLine($"The last day of the week for the above date is: { newDataTime.Date.ToString("dd/MM/yyyy")}");






Console.ReadLine();


Console.WriteLine("PLease enter a number (1-7)");
int day = int.Parse(Console.ReadLine());


Console.WriteLine((DayOfWeek)day);



Console.ReadLine();

 ------------------------------------------


Console.WriteLine("Please enter a first number: ");
int firstNumber =int.Parse( Console.ReadLine());
Console.WriteLine("Please enter a second number: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter a thrid number: ");
int thridNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"First number: {firstNumber}    Second number: {secondNumber}    Thrid number: {thridNumber}");

if(firstNumber > secondNumber && firstNumber > thridNumber)
{
    Console.WriteLine("The first number is greatest among three");
}else if(secondNumber >= firstNumber && secondNumber > thridNumber)
{
    Console.WriteLine("The second number is greatest among three");
}else if(firstNumber == secondNumber || firstNumber == thridNumber || secondNumber == thridNumber)
{
    Console.WriteLine("Please enter different numbers");
}
else
{
    Console.WriteLine("The thrid number is greatest among three");
}


Console.ReadLine(); 
--------------------------------*/

Console.WriteLine("Please first number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Please second number:");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("1-Addition.\r\n2-Substraction.\r\n3-Multiplication.\r\n4-Division.\r\n5-Exit.\r\nEnter your choice:");
int chocie = int.Parse(Console.ReadLine());
var result = 0;



switch (chocie)
{
    
    case 1: result = firstNumber + secondNumber; 
        Console.WriteLine($"Addition: {firstNumber}+{secondNumber}={result}");
        break;
    case 2:
        result = firstNumber - secondNumber; 
        Console.WriteLine($"Subsraction: {firstNumber}-{secondNumber}={result}");
        break;
    case 3:
        result = firstNumber * secondNumber; 
        Console.WriteLine($"Multiplication: {firstNumber}*{secondNumber}={result}");
        break;
    case 4:
        float result2 = Convert.ToSingle(result);
        result2 = Convert.ToSingle(firstNumber) / Convert.ToSingle(secondNumber); 
        Console.WriteLine($"Division: {firstNumber}:{secondNumber}={result2}");
        break;
        case 5:
        Console.WriteLine("Logging out");
        break;
    default:
        Console.WriteLine("Please choose a number between 1 and 5");
        break;
}




Console.ReadLine();

















