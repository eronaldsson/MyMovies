namespace MyMovies.Models
{
    public interface IMyMoviesRepository
    {
        //Get collection from database
        IQueryable<Movie>? Movies { get; }
        IQueryable<WatchList>? GetWatchLists { get; }
        IQueryable<WatchListMovies>? WatchListMoviestList { get; }

        //Get length from database
        int? GetWatchListLength { get; }

        //Add to database
        void AddMovieToWatchList(int movieId);
        void AddWatchList(string Title, string Creator);

    }
}
