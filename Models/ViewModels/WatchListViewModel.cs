using System;
namespace MyMovies.Models.ViewModels
{
    public class WatchListViewModel
    {
        public IEnumerable<WatchList>? WatchLists { get; set; }
        public IEnumerable<WatchListMovies>? WatchListMovies { get; set; }
        public int SelectedWatchList { get; set; }
    }
}

