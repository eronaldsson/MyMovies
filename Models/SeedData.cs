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
                Genre adventure = new Genre() { Name = "Adventure" };
                Genre animation = new Genre() { Name = "Animation" };
                Genre biography = new Genre() { Name = "Biography" };
                Genre comedy = new Genre() { Name = "Comedy" };
                Genre crime = new Genre() { Name = "Crime" };
                Genre documentary = new Genre() { Name = "Documentary" };
                Genre drama = new Genre() { Name = "Drama" };
                Genre family = new Genre() { Name = "Family" };
                Genre fantasy = new Genre() { Name = "Fantasy" };
                Genre horror = new Genre() { Name = "Horror" };
                Genre music = new Genre() { Name = "Music" };
                Genre musical = new Genre() { Name = "Musical" };
                Genre mystery = new Genre() { Name = "Mystery" };
                Genre romance = new Genre() { Name = "Romance" };
                Genre sciFi = new Genre() { Name = "Sci-Fi" };
                Genre sport = new Genre() { Name = "Sport" };
                Genre thriller = new Genre() { Name = "Thriller" };
                Genre war = new Genre() { Name = "War" };
                Genre western = new Genre() { Name = "Western" };


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
                },

                new Movie
                {
                    Title = "The Lion King",
                    Year = 1994,
                    Rating = 8.5m,
                    Genre = animation,
                    Mpaa = mpaaG
                },

                new Movie
                {
                    Title = "Bruce Almighty",
                    Year = 2003,
                    Rating = 6.8m,
                    Genre = comedy,
                    Mpaa = mpaaPg13
                },

                new Movie
                {
                    Title = "Star Trek",
                    Year = 2009,
                    Rating = 7.9m,
                    Genre = sciFi,
                    Mpaa = mpaaPg13
                },

                new Movie
                {
                    Title = "Remember the Titans",
                    Year = 2000,
                    Rating = 7.9m,
                    Genre = sport,
                    Mpaa = mpaaPg
                },

                new Movie
                {
                    Title = "Killer Klowns from Outer Space",
                    Year = 1988,
                    Rating = 6.1m,
                    Genre = horror,
                    Mpaa = mpaaPg13
                },

                new Movie
                {
                    Title = "Prisoners",
                    Year = 2013,
                    Rating = 8.1m,
                    Genre = crime,
                    Mpaa = mpaaR
                },

                new Movie
                {
                    Title = "Avatar",
                    Year = 2009,
                    Rating = 7.8m,
                    Genre = fantasy,
                    Mpaa = mpaaPg13
                },

                new Movie
                {
                    Title = "Jumanji: Welcome to the Jungle",
                    Year = 2017,
                    Rating = 6.9m,
                    Genre = adventure,
                    Mpaa = mpaaPg13
                },

                new Movie
                {
                    Title = "The Choice",
                    Year = 2016,
                    Rating = 6.5m,
                    Genre = romance,
                    Mpaa = mpaaPg13
                },

                new Movie
                {
                    Title = "The Prestige",
                    Year = 2006,
                    Rating = 8.5m,
                    Genre = mystery,
                    Mpaa = mpaaPg13
                },

                new Movie
                {
                    Title = "Shutter Island",
                    Year = 2010,
                    Rating = 8.2m,
                    Genre = thriller,
                    Mpaa = mpaaR
                },

                new Movie
                {
                    Title = "Avicii: True Stories",
                    Year = 2017,
                    Rating = 7.6m,
                    Genre = documentary,
                    Mpaa = mpaaPg
                },

                new Movie
                {
                    Title = "Home Alone",
                    Year = 1990,
                    Rating = 7.7m,
                    Genre = family,
                    Mpaa = mpaaPg
                },

                new Movie
                {
                    Title = "Blonde",
                    Year = 2022,
                    Rating = 5.5m,
                    Genre = biography,
                    Mpaa = mpaaNc17
                },

                new Movie
                {
                    Title = "Grease",
                    Year = 1978,
                    Rating = 7.2m,
                    Genre = musical,
                    Mpaa = mpaaPg
                },

                new Movie
                {
                    Title = "Pitch Perfect",
                    Year = 2012,
                    Rating = 7.1m,
                    Genre = music,
                    Mpaa = mpaaPg13
                },

                new Movie
                {
                    Title = "Saving Private Ryan",
                    Year = 1998,
                    Rating = 8.6m,
                    Genre = war,
                    Mpaa = mpaaR
                },

                new Movie
                {
                    Title = "Django Unchained",
                    Year = 2012,
                    Rating = 8.4m,
                    Genre = western,
                    Mpaa = mpaaR
                });

                context.SaveChanges();
            }
        }
    }
}