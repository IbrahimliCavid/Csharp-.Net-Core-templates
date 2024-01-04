namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <object> list = new List <object> ();
            int[] testArray = { 1, 2, 3 };
            
            list.Add (3285666662134234233);
            list.Add (-2);
            list.Add("Test");
            list.Add(testArray);
            list.Add('s');
            list.Add(false);

            foreach (object obj in list)
            {
                try
                {
                    double testDouble = Convert.ToDouble (obj);
                    Console.WriteLine ($"Successfully convert  {obj} to Double {testDouble}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"FormatException. Cannot convert {obj} to Double");

                }catch (InvalidCastException)
                {
                    Console.WriteLine($"InvalidCastException. Cannot convert {obj} to Double");
                }
                catch (Exception)
                {
                    Console.WriteLine($"Exception. Cannot convert {obj} to Double");
                }
            }
        }
    }
}