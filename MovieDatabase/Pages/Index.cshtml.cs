using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabase.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MovieDatabase.Data.MovieDatabaseContext _context;

        public IndexModel(MovieDatabase.Data.MovieDatabaseContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string Category { get; set; }

        public IEnumerable<Models.Image> AllImages { get; set; }
        public IEnumerable<Models.Image> Images { get; set; }

        public void OnGet()
        {
            AllImages = _context.Image;

            if (string.IsNullOrWhiteSpace(Category))
            {
                Images = AllImages;
            }
            else
            {
                Images = _context.Image.Where(Image => Image.Category == Category);
            }
        }
    }
}
