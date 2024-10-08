﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly _1_RazorPages.Data._1_RazorPagesContext _context;

        public DetailsModel(_1_RazorPages.Data._1_RazorPagesContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
