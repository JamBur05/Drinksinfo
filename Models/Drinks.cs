using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfo.Models
{
    public class Drink
    {
        public string idDrink { get; set; }
        public string strDrink { get; set; }
    }

    public class DrinksResponse
    {
        public List<Drink> drinks { get; set; }
    }

    public class DrinkInfo
    {
        public string idDrink { get; set; }
        public string strDrink { get; set; }
        public string strAlcoholic { get; set; }
        public string strGlass { get; set; }
        public string strInstructions { get; set; }
        public string strIngredient1 { get; set; }
        public string strIngredient2 { get; set; }
        public string strIngredient3 { get; set; }
        public string strIngredient4 { get; set; }
        public string strIngredient5 { get; set; }
        public string strIngredient6 { get; set; }
        public string strIngredient7 { get; set; }
        public string strIngredient8 { get; set; }
        public string strMeasure1 { get; set; }
        public string strMeasure2 { get; set; }
        public string strMeasure3 { get; set; }
        public string strMeasure4 { get; set; }
        public string strMeasure5 { get; set; }
        public string strMeasure6 { get; set; }
    }

    public class DetailedDrink
    {
        public List<DrinkInfo> drinks { get; set; }
    }
}