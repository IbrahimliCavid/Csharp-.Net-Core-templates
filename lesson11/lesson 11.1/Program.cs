using Newtonsoft.Json;

namespace lesson_11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            HttpClient client = new HttpClient();
            bool isContinue = true;

            while (isContinue)
            {
                Console.WriteLine();
                Console.WriteLine("Enter a name to check if it is male or female. (NOT: If you want to exit, type false.)");
                string personName = Console.ReadLine();

                if( personName == "false" || personName == "False")
                {
                    isContinue = false;
                    Console.WriteLine("Operation aborted");
                }
                else
                {
                   string Api = $"https://api.genderize.io/?name={personName}";
                   var result = client.GetStringAsync(Api).Result; 
                   var genderFilter = (GenderFilter)JsonConvert.DeserializeObject(result, typeof(GenderFilter));

                    if(genderFilter.Gender != null )
                    {
                        Console.WriteLine("Gender:" + genderFilter.Gender + "  Probabilitiy:" + genderFilter.Probability);
                    }
                    else
                    {
                        Console.WriteLine("This name does not exist in the system.");
                    }
                   
                }
                
            }
          
               

            
        }

        public class GenderFilter
        {
            public string Name { get; set; }
            public string Gender { get; set; }

            public double Probability {  get; set; }
        }
    }
}