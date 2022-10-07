using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace MyMovies.Models
{
    public class WatchList
    {
        public long WatchListId { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a creator")]
        public string Creator { get; set; } = string.Empty;

        public List<WatchListMovies>? WatchListMovies { get; set; }

    }
}
