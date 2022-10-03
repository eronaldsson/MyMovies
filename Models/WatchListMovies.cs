using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMovies.Models
{
    public class WatchListMovies
    {
        public long WatchListId { get; set; }
        public WatchList? WatchList { get; set; }
        public long MovieId { get; set; }
        public Movie? Movie { get; set; }
        [Column(TypeName = "decimal(3, 1)")]
        public decimal Rating { get; set; }
        public bool Watched { get; set; } = false;
    }
}
