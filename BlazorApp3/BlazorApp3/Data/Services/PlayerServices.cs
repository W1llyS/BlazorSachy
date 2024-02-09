using BlazorApp3.Data;
using BlazorApp3.Data.Classes; // Ensure this is correctly pointing to where Player1 is defined
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp3.Data.Services
{
    public class PlayerService
    {
        private readonly ApplicationDbContext _context;

        public PlayerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Player1>> GetPlayersAsync()
        {
            return await _context.Player1s.ToListAsync();
        }

        public async Task AddPlayerAsync(Player1 player)
        {
            _context.Player1s.Add(player);
            await _context.SaveChangesAsync();
        }
    }
}
