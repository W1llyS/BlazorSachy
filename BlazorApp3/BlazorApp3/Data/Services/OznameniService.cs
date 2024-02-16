using BlazorApp3.Data.Classes;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Data.Services
{
    public class OznameniService
    {
        private readonly ApplicationDbContext _context;

        public OznameniService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Oznameni>> GetOznameniAsync()
        {
            return await _context.Oznameni1s
                         .OrderByDescending(i => i.IdZ) // Works naturally with IDZ
                         .ToListAsync();
        }
        public async Task AddOznameniAsync(Oznameni oznameni)    // metoda ktera uklada data do databaze z addOznameni.razor
        {
            _context.Oznameni1s.Add(oznameni);         
            await _context.SaveChangesAsync(); 
        }

        




    }
}
