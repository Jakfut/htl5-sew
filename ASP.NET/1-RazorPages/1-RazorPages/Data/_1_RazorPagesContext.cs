using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _1_RazorPages.Models;

namespace _1_RazorPages.Data
{
    public class _1_RazorPagesContext : DbContext
    {
        public _1_RazorPagesContext (DbContextOptions<_1_RazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<_1_RazorPages.Models.Movie> Movie { get; set; } = default!;
    }
}
