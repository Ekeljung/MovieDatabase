using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieDatabase.Data;
using MovieDatabase.Models;

namespace MovieDatabase.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly MovieDatabase.Data.MovieDatabaseContext _context;

        public CreateModel(MovieDatabase.Data.MovieDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Image Image { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Image.Add(Image);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
