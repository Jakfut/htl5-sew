using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _1_RazorPages.Data;
using _1_RazorPages.Models;

namespace _1_RazorPages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly _1_RazorPages.Data._1_RazorPagesContext _context;

        public IndexModel(_1_RazorPages.Data._1_RazorPagesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
