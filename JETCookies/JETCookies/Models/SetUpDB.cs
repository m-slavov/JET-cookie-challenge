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
        }
    }
}
