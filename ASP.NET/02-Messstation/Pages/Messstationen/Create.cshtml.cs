using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _02_Messstation.Data;
using _02_Messstation.Models;

namespace _02_Messstation
{
    public class CreateModel : PageModel
    {
        private readonly _02_Messstation.Data.MessstationContext _context;

        public CreateModel(_02_Messstation.Data.MessstationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Messstation Messstation { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Messstation.Add(Messstation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
