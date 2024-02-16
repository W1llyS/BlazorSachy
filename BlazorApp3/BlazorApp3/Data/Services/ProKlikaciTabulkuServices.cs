using BlazorApp3.Data.Classes;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Data.Services
{
    public class ProklikaciTabulkuServices

    {
        private readonly ApplicationDbContext _context;

        public ProklikaciTabulkuServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProKlikaciTabulka1>> GetProKlikaciTabulka1sAsync()

        {
            return await _context.ProKlikaciTabulku1s.ToListAsync();

        }
    }
}
