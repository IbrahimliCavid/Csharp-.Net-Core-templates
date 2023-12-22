using System.Collections.Specialized;
using System.Diagnostics;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShutDownPC();
        }

        static void ShutDownPC()
        {
            Console.WriteLine("How many minute shutdown PC?");
            
            for (int i = 0; i < 2; i++)
            {
                int time = int.Parse(Console.ReadLine());
                if (time > 0)
                {
                    Console.WriteLine($"PC will shutdown {time} minute later...");
                    Thread.Sleep( 1000);
                    Process.Start("shutdown", $"/s /t {time * 5}");
                }
                else
                {
                    Console.WriteLine("Please enter less than 0.");
                    i = 0;
                }
            }
           
        }
    }
}