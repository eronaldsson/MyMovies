using Microsoft.EntityFrameworkCore;
namespace MyMovies.Models
{
    public static class SeedData
    {
        public static void SeedDatabase(MyMoviesDbContext context)
        {
            context.Database.Migrate();
            if (context.Movies.Count() == 0 && context.Genres.Count() == 0
            && context.Mpaas.Count() == 0)
            {
                Genre g1  = new() { Name = "Action" };
                Mpaa m1 = new() { Title = "PG-13", Description = "Some material may be inappropriate for children under 13" };

                context.Movies.AddRange(
                new Movie
                {
                    Title = "Batman Begins",
                    Year = 2005,
                    Rating = 8.2m,
                    Genre = g1,
                    Mpaa = m1
                });

                context.SaveChanges();
            }
        }
    }
}