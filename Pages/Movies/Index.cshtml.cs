using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorsPagesMovie.Data;

namespace RazorsPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorsPagesMovieContext _context;

        public IndexModel(RazorsPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
