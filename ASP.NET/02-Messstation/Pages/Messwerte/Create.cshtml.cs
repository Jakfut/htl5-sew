using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _02_Messstation.Data;
using _02_Messstation.Models;

namespace _02_Messstation
{
    public class CreateMesswert : PageModel
    {
        private readonly _02_Messstation.Data.MessstationContext _context;

        public CreateMesswert(_02_Messstation.Data.MessstationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MessstationId"] = new SelectList(_context.Messstation, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Messwert Messwert { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            Messwert.Id = RandomNumberGenerator.GetInt32(0, 1000000);
            /*if (!ModelState.IsValid)
            {
                return Page();
            }*/

            _context.Messwert.Add(Messwert);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
