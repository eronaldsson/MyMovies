using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace MyMovies.Models
{
    public class WatchList
    {
        public long WatchListId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Creator { get; set; } = string.Empty;

        public List<WatchListMovies>? WatchListMovies { get; set; }

    }
}
