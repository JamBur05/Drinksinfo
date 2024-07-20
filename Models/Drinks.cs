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
}
