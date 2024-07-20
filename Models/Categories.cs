using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfo.Models
{
    public class Categories
    {
        public List<Category> drinks { get; set; }
    }

    public class Category
    {
        public string strCategory { get; set; }
    }
}
