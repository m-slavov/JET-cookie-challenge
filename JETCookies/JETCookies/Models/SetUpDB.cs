using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace JETCookies.Models
{
    public class SetUpDB
    {
        public static void PrepareDB(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                AddData(serviceScope.ServiceProvider.GetService<DataContext>());
            }
        }

        public static void AddData(DataContext cookiesDBContext)
        {
            cookiesDBContext.Database.Migrate();
            if (!cookiesDBContext.CookieItems.Any())
            {
                cookiesDBContext.CookieItems.AddRange(

                    new Cookie() { Name = "Chocolate Chip Cookies", Calories=488, Weight=100 }, //id 1
                    new Cookie() { Name = "Shortbread Cookies", Calories=502, Weight=100 }, //id 2
                    new Cookie() { Name= "Macaron Cookies", Calories=404, Weight=100 } //id 3

                    );
                cookiesDBContext.SaveChanges();

                cookiesDBContext.IngredientItems.AddRange(
                    
                    new Ingredient() { Name="Dark chocolate" }, //id 1
                    new Ingredient() { Name = "Sugar" }, //id 2
                    new Ingredient() { Name = "Vanilla extract" }, //id 3
                    new Ingredient() { Name ="Butter"} //id 4

                    );
                cookiesDBContext.SaveChanges();

                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 1, IngredientId = 1 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 1, IngredientId = 2 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 2, IngredientId = 2 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 2, IngredientId = 4 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 3, IngredientId = 2 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 3, IngredientId = 3 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 3, IngredientId = 4 });
                cookiesDBContext.SaveChanges();
            }
        }
    }
}
