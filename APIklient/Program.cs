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

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Karaktär karaktären = JsonConvert.DeserializeObject<Karaktär>(response.Content);

                // Console.WriteLine($"Pokemon: {thePokemon.Name} - XP: {thePokemon.BaseExperience}");

                Console.WriteLine(karaktären.Abilities[1].Name);
            }

            
            System.Console.ReadLine();
        }
    }
}
