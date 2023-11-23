using Newtonsoft.Json;

namespace lesson_11._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
           
         
            string name = "";
            while (name != "0")
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a name. (NOT: If you want to exit press to `0` )");
                name = Console.ReadLine();
                if (name == "0")
                {
                    Console.WriteLine("To Exit...");
                }
                else
                {

                    var ApiUrl = $"https://api.nationalize.io/?name={name}";
                    var result = client.GetStringAsync(ApiUrl).Result;
                    var nationaly = JsonConvert.DeserializeObject<Nationaly>(result);
                    for (int i = 0; i < nationaly.Country.Length; i++)
                    {
                        Console.WriteLine($"{nationaly.Country[i].Country_id} - Probability: {nationaly.Country[i].Probability * 100}% ");
                    }
                }



            }
        }

        public class Nationaly
        {
            public Country[] Country { get; set; }

        }

        public class Country
        {
            public string Country_id { get; set; }
            public float Probability {  get; set; }
        }
    }
}