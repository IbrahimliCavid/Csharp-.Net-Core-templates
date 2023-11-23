using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace lesson11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isContinue;
            const string Api = "https://www.boredapi.com/api/activity";

            HttpClient client = new HttpClient();

            do
            {
                Console.WriteLine("Your daily activity: ");
                var result = client.GetStringAsync(Api).Result;
                var boredApi = JsonConvert.DeserializeObject<BoredApi>(result);
                Console.WriteLine($"{boredApi.Activity }\r\n");
                Console.WriteLine($"Activity type: {boredApi.Type} \r\n" );
                Console.WriteLine($"Number of participants: {boredApi.Participants}");
                
              
                isContinue = Convert.ToBoolean(Console.ReadLine());
               

            } while (isContinue);
        }

        public class BoredApi
        {
            public string Activity { get; set; }
            public string Type { get; set; }
            public int Participants { get; set; }
            public float Price { get; set; }
        }
    }
}