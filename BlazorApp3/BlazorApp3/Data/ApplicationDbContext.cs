using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorApp3.Data.Classes; // Ensure this using directive is correct for your Oznameni class location

namespace BlazorApp3.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Oznameni> Oznameni1s { get; set; }
        public DbSet<Elo1> Elo1s { get; set; }//////////////////////////////////////added 
        public DbSet<Player1> Player1s { get; set; }//////////////////////////////////////added 
        public DbSet<ProKlikaciTabulka1> ProKlikaciTabulku1s { get; set; }//////////////////////////////////////added 
        public DbSet<Turnaj1> Turnaj1s { get; set; }//////////////////////////////////////added 
        public DbSet<Vysledek1> Vysledek1s { get; set; }//////////////////////////////////////added 


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // If you have any model configuration for your Oznameni entity, it can go here
            // For example, defining relationships, indexes, or data seeding
        }
    }
}
