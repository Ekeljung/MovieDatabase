using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieDatabase.Data;
using MovieDatabase.Models;

namespace MovieDatabase.Pages.Admin
{
    public class DeleteModel : PageModel
    {
        private readonly MovieDatabase.Data.MovieDatabaseContext _context;

        public DeleteModel(MovieDatabase.Data.MovieDatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Image Image { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Image = await _context.Image.FirstOrDefaultAsync(m => m.ID == id);

            if (Image == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Image = await _context.Image.FindAsync(id);

            if (Image != null)
            {
                _context.Image.Remove(Image);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
