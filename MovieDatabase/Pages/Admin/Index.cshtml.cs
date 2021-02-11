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
    public class IndexModel : PageModel
    {
        private readonly MovieDatabase.Data.MovieDatabaseContext _context;

        public IndexModel(MovieDatabase.Data.MovieDatabaseContext context)
        {
            _context = context;
        }

        public IList<Image> Image { get;set; }

        public async Task OnGetAsync()
        {
            Image = await _context.Image.ToListAsync();
        }
    }
}
