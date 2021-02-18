using System;
using RestSharp;
using Newtonsoft.Json;

namespace APIklient
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("http://stapi.co/api/v1/rest/season/search");
            RestRequest request = new RestRequest("");
            IRestResponse response = client.Get(request);
            Console.WriteLine(response.Content);
            System.Console.ReadLine();

            Pokemon newPokemon = JsonConvert.DeserializeObject<Pokemon>(response.Content);
        }
    }
}
