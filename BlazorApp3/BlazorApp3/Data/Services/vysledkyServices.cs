using BlazorApp3.Data.Classes;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Data.Services
{
    public class vysledkyServices

    {
        private readonly ApplicationDbContext _context;

        public vysledkyServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Vysledek1>> GetVysledek1sAsync()



        {
            return await _context.Vysledek1s.ToListAsync();


        }
    }
}
