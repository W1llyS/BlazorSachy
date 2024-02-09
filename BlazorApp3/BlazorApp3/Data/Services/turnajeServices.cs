using BlazorApp3.Data;
using BlazorApp3.Data.Classes;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp3.Data.Services
{
    public class turnajeServices

    {
        private readonly ApplicationDbContext _context;

        public turnajeServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Turnaj1>> GetTurnaj1sAsync()
            


        {
            return await _context.Turnaj1s.ToListAsync();
           

        }
    }
}
