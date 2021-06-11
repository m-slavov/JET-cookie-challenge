using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JETCookies.Models
{
    public class Cookie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Calories { get; set; }
        public virtual List<CookieIngredient> CookieIngredients { get; set; }
    }
}
