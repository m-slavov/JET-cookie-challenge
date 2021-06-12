﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JETCookies.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingredient must have a name value")]
        public string Name { get; set; }

        public virtual List<CookieIngredient> CookieIngredients { get; set; }
    }
}
