using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Microsoft.EntityFrameworkCore;
namespace Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IApplicationDbContext _context;
        public ItemService (IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Item>> GetItems()
        {
           return await _context.Items.ToListAsync();
        }
    }
}
