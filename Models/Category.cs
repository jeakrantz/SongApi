using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace SongApi.Models;

public class Category
{
    //Properties
    public int Id { get; set; }
    [Required]

    public string? Name { get; set; }

    public List<Song>? Songs { get; set; }
}

