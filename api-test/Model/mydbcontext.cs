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
