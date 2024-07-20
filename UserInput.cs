using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfo
{
    internal class UserInput
    {
        DrinksService service = new DrinksService();

        public async Task GetInputCategories()
        {
            await service.GetCategories();

            Console.WriteLine("Enter a category number to see drinks: ");
            string category = Console.ReadLine();


            service.GetDrinksByCategory(category).Wait();
        }
    }
}
