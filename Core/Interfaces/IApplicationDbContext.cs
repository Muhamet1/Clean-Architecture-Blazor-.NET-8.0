using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Item> Items { get; set; }
        Task<int> SaveChangesAsync();
    }
}
