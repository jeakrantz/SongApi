using System.ComponentModel.DataAnnotations;

namespace SongApi.Models;

public class Song
{
    //Properties
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Artist { get; set; }
    [Required]
    public int Length { get; set; }

    //Kopplar en specifik kategori till låten som lägg till
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
}

