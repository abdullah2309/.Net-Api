using Microsoft.EntityFrameworkCore;

namespace api_test.Model
{
    public class mydbcontext : DbContext
    {
        public mydbcontext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<product> products { get; set; }
    }
}
///dbcontext is a class that is derived from Entity Framework Core's DbContext class. It is used to query from a database and group together changes that will be written to the database.
