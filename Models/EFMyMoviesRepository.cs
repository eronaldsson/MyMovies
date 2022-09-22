using Microsoft.EntityFrameworkCore;

namespace MyMovies.Models
{
    public class EFMyMoviesRepository : IMyMoviesRepository
    {
        private MyMoviesDbContext context;

        public EFMyMoviesRepository(MyMoviesDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Movie>? Movies => context.Movies
            .Include(g => g.Genre)
            .Include(m => m.Mpaa);
    }
}
