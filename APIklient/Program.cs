using System;
using RestSharp;
using Newtonsoft.Json;

namespace APIklient
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");
            RestRequest request = new RestRequest("pokemon/ditto");
            IRestResponse response = client.Get(request);
            Console.WriteLine(response.Content);
            System.Console.ReadLine();

            Pokemon newPokemon = JsonConvert.DeserializeObject<Pokemon>(response.Content);

        }
    }
}
