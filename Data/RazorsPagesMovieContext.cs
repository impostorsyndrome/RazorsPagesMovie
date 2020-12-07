using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorsPagesMovie.Data
{
    public class RazorsPagesMovieContext : DbContext
    {
        public RazorsPagesMovieContext (DbContextOptions<RazorsPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
