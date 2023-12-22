namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;

            num1 = 3;
            num2 = 60;
           
           
            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a smaller numbers");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 


        }
    }
}