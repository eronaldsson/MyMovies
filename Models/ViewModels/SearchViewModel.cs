using System;
using MyMovies.Models;

namespace MyMovies.Models.ViewModels
{
	public class SearchViewModel
	{
        public IEnumerable<Movie>? Movies { get; set; }
        public IEnumerable<WatchList>? WatchLists { get; set; }
        public IEnumerable<long>? MovieIds { get; set; }
        public int SelectedWatchList { get; set; }
    }
}