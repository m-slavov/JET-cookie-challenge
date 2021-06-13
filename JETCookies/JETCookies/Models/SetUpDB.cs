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

                    new Cookie() { Name = "Macaron", Calories=97, Weight=24 , Image="macaron"}, //id 1
                    new Cookie() { Name = "Chocolate Chip Cookie", Calories=78, Weight=16, Image="chocolate-chip" }, //id 2
                    new Cookie() { Name= "Scottish Shortbread", Calories=40, Weight=8, Image="shortbread" }, //id 3
                    new Cookie() { Name= "Savoiardi", Calories=27.5, Weight=7.5, Image="savoiardi" }, //id 4
                    new Cookie() { Name= "Zimtsterne", Calories=130, Weight=30.0, Image="zimtsterne" } //id 5

                    );
                cookiesDBContext.SaveChanges();

                cookiesDBContext.IngredientItems.AddRange(
                    
                    new Ingredient() { Name="Sugar", Image="sugar"}, //id 1
                    new Ingredient() { Name = "Almond", Image="almond" }, //id 2
                    new Ingredient() { Name = "Egg", Image="egg" }, //id 3
                    new Ingredient() { Name = "Salt", Image="salt" }, //id 4
                    new Ingredient() { Name = "Baking soda", Image="baking-soda" }, //id 5
                    new Ingredient() { Name = "Chocolate", Image="chocolate-bar" }, //id 6
                    new Ingredient() { Name = "Butter", Image="butter" }, //id 7
                    new Ingredient() { Name = "Flour", Image="flour" }, //id 8
                    new Ingredient() { Name = "Vanilla", Image="vanilla" }, //id 9
                    new Ingredient() { Name = "Hazelnut", Image="hazelnut" }, //id 10
                    new Ingredient() { Name = "Cinnamon", Image="cinnamon" } //id 11
                    );
                cookiesDBContext.SaveChanges();

                //Macaron
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 1, IngredientId = 1 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 1, IngredientId = 2 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 1, IngredientId = 3 });
                //Chocolate Chip Cookie
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 2, IngredientId = 4 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 2, IngredientId = 6 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 2, IngredientId = 5 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 2, IngredientId = 3 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 2, IngredientId = 7 });
                //Scottish Shortbread
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 3, IngredientId = 7 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 3, IngredientId = 1 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 3, IngredientId = 8 });
                //Savoiardi
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 4, IngredientId = 8 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 4, IngredientId = 3 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 4, IngredientId = 1 });
                //Zimtsterne
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 5, IngredientId = 3 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 5, IngredientId = 1 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 5, IngredientId = 11 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 5, IngredientId = 2 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 5, IngredientId = 10 });
                cookiesDBContext.CookieIngredients.Add(new CookieIngredient() { CookieId = 5, IngredientId = 9 });

                cookiesDBContext.SaveChanges();
            }
        }
    }
}
