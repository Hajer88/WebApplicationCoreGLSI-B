using Microsoft.EntityFrameworkCore;

namespace WebApplicationCoreGLSI_B.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions
            <AppDbContext> options):base(options)
        {

        }
        public DbSet<Categorie> cats { get; set; }
        public DbSet<SousCategorie> sscats { get; set; }
    
        protected override void OnModelCreating(ModelBuilder model)
        { 
            
        }
    
    }
}
