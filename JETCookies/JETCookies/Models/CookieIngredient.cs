using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JETCookies.Models
{
    public class CookieIngredient
    {
        public int CookieId { get; set; }
        public Cookie Coookie { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
