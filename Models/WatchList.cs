using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace MyMovies.Models
{
    public class WatchList
    {
        public long WatchListId { get; set; }


        [Column(TypeName = "decimal(3, 1)")]
        public decimal MyRating { get; set; }

        public List<WatchListMovies>? WatchListMovies { get; set; }

    }
}
