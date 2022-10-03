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


                Genre action = new Genre() { Name = "Action" };
                Genre drama = new Genre() { Name = "Drama" };


                Mpaa mpaaG = new() { Title = "G", Description = "Nothing that would offend parents for viewing by children."};
                Mpaa mpaaPg = new() { Title = "PG", Description = "Parents urged to give 'parental guidance.' May contain some material parents might not like for their young children."};
                Mpaa mpaaPg13 = new() { Title = "PG-13", Description = "Parents are urged to be cautious. Some material may be inappropriate for pre-teenagers."};
                Mpaa mpaaR = new() { Title = "R", Description = "Contains some adult material. Parents are urged to learn more about the film before taking their young children with them."};
                Mpaa mpaaNc17 = new() { Title = "NC-17", Description = "Clearly adult. Children are not admitted."};


                context.Movies.AddRange(
                new Movie
                {
                    Title = "Batman Begins",
                    Year = 2005,
                    Rating = 8.2m,
                    Genre = action,
                    Mpaa = mpaaPg13
                },

                new Movie
                {
                    Title = "The Shawshank Redemption",
                    Year = 1994,
                    Rating = 9.2m,
                    Genre = drama,
                    Mpaa = mpaaR
                });

                //context.WatchLists.Add(new WatchList
                //{
                //    Title = "The best",
                //    Creator = "Arnold"
                //});

                //context.WatchLists.Add(new WatchList
                //{
                //    Title = "Second best",
                //    Creator = "Emil"
                //});


                context.SaveChanges();
            }
        }
    }
}