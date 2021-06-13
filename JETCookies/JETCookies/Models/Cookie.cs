using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JETCookies.Models
{
    public class Cookie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The cookie must have a name value")]
        public string Name { get; set; }
        public string Image{ get; set; }
        public double Weight { get; set; }

        public double Calories { get; set; }

        public virtual List<CookieIngredient> CookieIngredients { get; set; }
    }
}
