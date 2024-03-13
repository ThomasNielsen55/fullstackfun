using Microsoft.EntityFrameworkCore;

namespace fullstackFunback.Data
{
    public class MFoodContext : DbContext
    {
        public MFoodContext(DbContextOptions<MFoodContext> options) : base(options) { }

        public DbSet<MarriottFood> Foods { get; set; }
    }
}
