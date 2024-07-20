using DrinksInfo.Models;
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
        public async Task GetCategories()
        {
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/");
            var request = new RestRequest("list.php?c=list");

            // Execute the request and get the response
            var response = await client.ExecuteAsync(request);

            // Ensure response content is not null
            if (response.Content == null)
            {
                throw new Exception("Response content is null");
            }

            // Deserialize the JSON response
            var categoryResponse = JsonConvert.DeserializeObject<Categories>(response.Content);

            // Check if the deserialization was successful
            if (categoryResponse == null || categoryResponse.drinks == null)
            {
                throw new Exception("Failed to deserialize response");
            }

            // Print the categories in a nice format

            TableDisplayer.DisplayTable<Category>(categoryResponse.drinks, "Categories");

            Console.WriteLine("CATEGORIES");
            int index = 1;
            foreach (var drink in categoryResponse.drinks)
            {
                Console.WriteLine($"{index}: {drink.strCategory}");
                index++;
            }
        }

        public async Task GetDrinksByCategory(string category)
        {
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/");
            var request = new RestRequest("filter.php?c=" + category);

            // Execute the request and get the response
            var response = await client.ExecuteAsync(request);

            // Ensure response content is not null
            if (response.Content == null)
            {
                throw new Exception("Response content is null");
            }

            // Deserialize the JSON response
            var drinkResponse = JsonConvert.DeserializeObject<DrinksResponse>(response.Content);

            // Check if the deserialization was successful
            if (drinkResponse == null || drinkResponse.drinks == null)
            {
                throw new Exception("Failed to deserialize response");
            }

            // Print the categories in a nice format
            Console.WriteLine("DRINKS");
            int index = 1;
            foreach (var drink in drinkResponse.drinks)
            {
                Console.WriteLine($"{index}: {drink.strDrink}");
                index++;
            }
        }
    }
}

