
using Microsoft.EntityFrameworkCore;


namespace DockerAPI.Models
{

    public class CustomerContext : DbContext
    {

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
            //options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));

        }


        public DbSet<Customer> Customers { get; set; }

    }
}