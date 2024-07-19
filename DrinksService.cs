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
        public static async Task<Category> GetCategoriesAsync()
        {
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/");
            var request = new RestRequest("list.php?c=list");

            // Await the asynchronous request
            var response = await client.ExecuteAsync(request);

            // Ensure response content is not null
            if (response.Content == null)
            {
                throw new Exception("Response content is null");
            }

            // Deserialize the JSON content
            var conversion = JsonConvert.DeserializeObject<Category>(response.Content);
            return conversion;
        }
    }

    public class Category
    {
        public List<string> Categories { get; set; }
    }
}
