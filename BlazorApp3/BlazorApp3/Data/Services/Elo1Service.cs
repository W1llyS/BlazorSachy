using BlazorApp3.Data.Classes;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Data.Services
{
    public class Elo1Service
    {
        private readonly ApplicationDbContext _context;

        public Elo1Service(ApplicationDbContext context2)
        {
            _context = context2;
        }

        public async Task<List<Elo1>> GetElo1sAsync() 
        {
            return await _context.Elo1s.ToListAsync();
        }
    }
}
