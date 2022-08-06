using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;


namespace DockerAPI.Models
{

    public static class CustomerPrepDB
    {

        public static void Prepopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<CustomerContext>());
            }
        }

        public static void SeedData(CustomerContext customerContext)
        {
            System.Console.WriteLine("Applying Database migration");

            customerContext.Database.Migrate();

            if(!customerContext.Customers.Any())
            {
                System.Console.WriteLine("Adding Data");

                customerContext.Customers.AddRange(

                    new Customer(){FirstName = "David 1",  LastName = "Backhum 1", Email = "David1@gmail.com", CreationDate = DateTime.UtcNow, MobileNumber="44013232555522", Remarks="Migration"},
                    new Customer(){FirstName = "David 2",  LastName = "Backhum 2", Email = "David2@gmail.com", CreationDate = DateTime.UtcNow, MobileNumber="44013232555522", Remarks="Migration"},
                    new Customer(){FirstName = "David 3",  LastName = "Backhum 3", Email = "David3@gmail.com", CreationDate = DateTime.UtcNow, MobileNumber="44013232555522", Remarks="Migration"},
                    new Customer(){FirstName = "David 4",  LastName = "Backhum 4", Email = "David4@gmail.com", CreationDate = DateTime.UtcNow, MobileNumber="44013232555522", Remarks="Migration"},
                    new Customer(){FirstName = "David 5",  LastName = "Backhum 5", Email = "David5@gmail.com", CreationDate = DateTime.UtcNow, MobileNumber="44013232555522", Remarks="Migration"},
                    new Customer(){FirstName = "David 6",  LastName = "Backhum 6", Email = "David6@gmail.com", CreationDate = DateTime.UtcNow, MobileNumber="44013232555522", Remarks="Migration"}
                );

            }
            else 
            {
                System.Console.WriteLine("Already data migrated");
            }
        }
    }
}