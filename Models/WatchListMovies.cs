using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMovies.Models
{
    public class WatchListMovies
    {
        public long WatchListId { get; set; }
        public WatchList? WatchList { get; set; }
        public long MovieId { get; set; }
        public Movie? Movie { get; set; }

        [Range(1, 10)]
        public int Rating { get; set; } = 1;
        public bool Watched { get; set; } = false;
    }
}
