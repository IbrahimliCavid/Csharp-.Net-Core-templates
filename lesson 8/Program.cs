using System.Collections;

namespace lesson_8_template
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            static int socketPairs(int n, List<int> arr)
            {
                int index = 0;

                int[] arr2 = new int[n];


                int pairs = 0;

                for (int i = 0; i < arr.Count; i++)
                {
                    for (int j = 0; j < arr.Count; j++)
                    {
                        if (arr[i] == arr[j] && i < j && (!arr2.Contains(i) || i == 0))
                        {
                            arr2[index] = j;
                            index++;
                            pairs += 1;
                            break;
                        }
                    }
                }
                return pairs;

            }

          

          

            





            List<int> arr = new List<int>();
            arr.Add(1);
            arr.Add(3);
            arr.Add(1);
            arr.Add(4);
            arr.Add(3);
            arr.Add(1);
            arr.Add(2);

            //Console.WriteLine(socketPairs(7, arr));



             static string kangaroo(int x1, int v1, int x2, int v2)
            {
                string result = "";
                List<int> kangaroo1 =  new List<int>();
                kangaroo1.Add(x1);
                List<int> kangaroo2 = new List<int>();
                kangaroo2.Add(x2);



                for (int i = 0; i < 10000; i++)
                {
                    kangaroo1.Add(kangaroo1[i] + v1);
                    kangaroo2.Add(kangaroo2[i] + v2);

                    if (kangaroo1[i] == kangaroo2[i])
                    {
                        result = "YES";
                        break;
                    }
                    else
                    {
                        result = "NO";
                        continue;
                    }
                    
                }

           

                return result;
            }

            //Console.WriteLine(kangaroo(2, 4, 4, 3));

           static int divisibleSumPairs(int n, int k, List<int> ar)
            {
                int pairs = 0;
                for (int i = 0; i < ar.Count; i++)
                {
                    i = 0;
                    for(int j = 1; j < ar.Count; j++)                                                       
                    {
                        if ((ar[i] + ar[j]) % k == 0)
                        {
                            pairs++;
                        }
                        if (j == ar.Count-1)
                        {
                            ar.Remove(ar[0]);
                           
                          

                        }
                       
                    }
                }

                
                return pairs;
            }

            List<int> ar = new List<int>();
            ar.Add(5);
            ar.Add(9);
            ar.Add(10);
            ar.Add(7);
            ar.Add(4);
            //Console.WriteLine(divisibleSumPairs(6, 2, ar));

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(a);

        }


    }
}