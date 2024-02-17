using Microsoft.EntityFrameworkCore;
using TemporalBoxApi.Models;

namespace TemporalBoxApi.JwtContext
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options ):base(options)
        {
            
        }

       public DbSet<Categories> Categories { get; set; }
       public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubCategory>()
                .HasOne(sc => sc.Category)
                .WithMany(c => c.SubCategoryList)
                .HasForeignKey(sc => sc.CategoryId);
        }
    }
}
