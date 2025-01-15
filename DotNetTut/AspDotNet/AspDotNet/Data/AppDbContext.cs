using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AspDotNet.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> Options): base(Options)
        {
            
        }
    }
}
