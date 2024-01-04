using System.Diagnostics;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int? number;
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even number");
                }
                else
                {
                    Console.WriteLine($"{number} is a odd number");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException. Can't convert word to Int. Please enter a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexcpected error occurred");
            }

            
        }
    }
}