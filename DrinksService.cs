using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfo
{
    public class DrinksService
    {
        public static void GetCategories()
        {
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/");
            var request = new RestRequest("list.php?c=list");

            // Execute the request and get the response
            var response = client.Execute(request);

            // Ensure response content is not null
            if (response.Content == null)
            {
                throw new Exception("Response content is null");
            }

            // Deserialize the JSON response
            var drinksResponse = JsonConvert.DeserializeObject<DrinksResponse>(response.Content);

            // Check if the deserialization was successful
            if (drinksResponse == null || drinksResponse.drinks == null)
            {
                throw new Exception("Failed to deserialize response");
            }

            // Print the categories in a nice format
            foreach (var drink in drinksResponse.drinks)
            {
                Console.WriteLine($"Category: {drink.strCategory}");
            }
        }

    }

    public class Drink
    {
        public string strCategory { get; set; }
    }

    public class DrinksResponse
    {
        public List<Drink> drinks { get; set; }
    }

}

