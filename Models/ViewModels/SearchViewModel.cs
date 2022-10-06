using System;
namespace MyMovies.Models.ViewModels
{
	public class SearchViewModel
	{
        public IEnumerable<Movie>? Movies { get; set; }
        public IEnumerable<WatchList>? WatchLists { get; set; }
        public int SelectedWatchList { get; set; }
    }
}

