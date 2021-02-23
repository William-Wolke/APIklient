using System;
using RestSharp;
using Newtonsoft.Json;

namespace APIklient
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://swapi.dev/api/");
            RestRequest request = new RestRequest("people/1/");
            IRestResponse response = client.Get(request);



            Console.WriteLine(response.Content);

            
            System.Console.ReadLine();
        }
    }
}
