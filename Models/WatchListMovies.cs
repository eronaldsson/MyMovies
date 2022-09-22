namespace MyMovies.Models
{
    public class WatchListMovies
    {
        public long WatchListMoviesId { get; set; }
        public long WatchListId { get; set; }
        public WatchList? WatchList { get; set; }
        public long MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}
