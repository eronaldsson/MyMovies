namespace MyMovies.Models
{
    public interface IMyMoviesRepository
    {
        //Get collection from database
        IQueryable<Movie>? Movies { get; }
        IQueryable<WatchList>? GetWatchLists { get; }
        IQueryable<WatchListMovies>? GetWatchListMoviestListWithInfo(int WatchListId);
        IQueryable<long>? GetMovieIds(int WatchListId);

        //Get length from database
        int? GetWatchListLength { get; }

        //Add to database
        void AddMovieToWatchList(int watchListId, int movieId);
        void AddWatchList(string Title, string Creator);

        //Update database
        void UpdateMovieAsWatched(int watchListId, int movieId);
    }
}
