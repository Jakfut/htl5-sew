using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02_Messstation.Models;
using Microsoft.EntityFrameworkCore;

namespace _02_Messstation.Data
{
    public class MessstationContext : DbContext
    {
        public MessstationContext (DbContextOptions<MessstationContext> options)
            : base(options)
        {
        }

        public DbSet<_02_Messstation.Models.Messstation> Messstation { get; set; } = default!;
        public DbSet<_02_Messstation.Models.Messwert> Messwert { get; set; } = default!;
    }
}