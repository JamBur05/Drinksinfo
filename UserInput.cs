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

            Console.WriteLine("Enter a category number to see drinks or type \"EXIT\" to quit: ");
            string category = Console.ReadLine();

            if(category.ToUpper() == "EXIT")
            {
                Environment.Exit(0);
            }
            else
            {
                service.GetDrinksByCategory(category).Wait();
                GetDrinkChoice().Wait();
            }
        }

        public async Task GetDrinkChoice()
        {
            Console.WriteLine("Enter a drink number to see ingredients or \"0\" to return to categories: ");
            string drink = Console.ReadLine();

            if(drink == "0")
            {
                await GetInputCategories();
            }
            else
            { 
                await service.GetDrinkByName(drink);
            }
        }
    }
}
