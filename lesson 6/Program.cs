using System;

namespace lesson_6_template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HandleSort();
            //ThridMaxElement();
            //FirstFourMaxElement();
            ChangeToNumNotVariable();
        }

        static void HandleSort()
        {
            List<int> numbers = new List<int>();
             Random random = new Random();

            for (int i = 0; i < 90; i++)
            {
                numbers.Add(random.Next(10, 100));
                Console.WriteLine($"List: {numbers[i]}");
            }

            

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int a = numbers[i];
                    int b = numbers[j];
                    if (a < b)
                    {
                        numbers[i] = b;
                        numbers[j]=a;
                    }
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"List sort: {numbers[i]}");
            }
          
        }

        static void ThridMaxElement()
        {
            List<int> numbers = new ();
            Random random = new ();
           

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(random.Next(10, 100));
         
            } 
            numbers.Sort();
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"List: {numbers[i]}");
            }

            int count1 = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if ( numbers[i] == numbers.Max())
                {
                    count1++;
                }
            }

            int count2 = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[count1])
                {
                    count2++;
                }
            }

            int count = count1 + count2;




            Console.WriteLine(numbers[count]);

        }

        static void FirstFourMaxElement()
        {
            List<int> numbers = new();
            Random random = new();


            for (int i = 0; i < 100; i++)
            {
                numbers.Add(random.Next(10, 100));

            }
            numbers.Sort();
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"List: {numbers[i]}");
            }



            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numbers.Remove(numbers[i]);
                        i = 0;
                    }
                }
            }

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"{i}. Max Element: {numbers[i]}");
            }

            
        }

        static void   ChangeToNumNotVariable()
        {
            int a = 5;
            int b = 6;

            a = a + b;
            b = a - b;
            a = a - b;
            


            Console.WriteLine($"{a} {b}");
        }
    }

}