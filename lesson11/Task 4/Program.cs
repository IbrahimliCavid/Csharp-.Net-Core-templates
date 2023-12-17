using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;

namespace Task4
{
    public class Program
    {
        const string ApiUrl = "https://dog.ceo/api/breeds/image/random";
        const string MyDirectory = "C:\\Dog Photos";
        
        static void Main(string[] args)
        {

            DownloadPhotoToFolder();
         
         

        }

        static string GetPhotoFromUrl()
        {
            HttpClient client = new HttpClient();
             var result = client.GetStringAsync(ApiUrl).Result;
            Dogs dogs = JsonConvert.DeserializeObject<Dogs>(result);
         
            return dogs.Message;
        }

           

        static void DownloadPhotoToFolder()
        {
            string url = GetPhotoFromUrl();
            var fileName = url.Split("/");
            string photoName = fileName[fileName.Length - 1];

           
            
           
            WebClient client = new WebClient();


            client.DownloadFile(GetPhotoFromUrl(), MyDirectory + $"\\{photoName}");

            Console.WriteLine($"{photoName} downloading successfuly.");

        }
    }

    public class Dogs
    {

        public string Message { get; set; }


        public string Status { get; set; }
    }
}