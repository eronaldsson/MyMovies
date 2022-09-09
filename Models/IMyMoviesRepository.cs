namespace MyMovies.Models
{
    public interface IMyMoviesRepository
    {
        IQueryable<Movie>? Movies { get; }
    }
}
