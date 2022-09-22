using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMovies.Models
{
    public class Movie
    {
        public long MovieId { get; set; }

        public string Title { get; set; } = string.Empty;

        public int Year { get; set; }

        [Column(TypeName = "decimal(3, 1)")]
        public decimal Rating { get; set; }

        public long GenreId { get; set; }
        public Genre? Genre { get; set; }

        public long MpaaId { get; set; }
        public Mpaa? Mpaa { get; set; }

        public List<WatchListMovies>? WatchListMovies { get; set; }
    }
}
