namespace MyMovies.Models
{
    public interface IMyMoviesRepository
    {
        IQueryable<Movie>? Movies { get; }

        public void AddMovieToWatchList(int movieId);

        public IQueryable<WatchListMovies>? WatchListMoviestList { get; }

        public int? GetWatchListLength { get; }

        public IQueryable<WatchList>? GetWatchLists { get; }

        public void AddWatchList(string Title, string Creator);

    }
}
