using BlazorApp3.Data;
using BlazorApp3.Data.Classes;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp3.Data.Services
{
    public class ProklikaciTabulkuServices

    {
        private readonly ApplicationDbContext _context;

        public ProklikaciTabulkuServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProKlikaciTabulka1>>GetProKlikaciTabulka1sAsync() 
           
        {
            return await _context.ProKlikaciTabulku1s.ToListAsync();

        }
    }
}
