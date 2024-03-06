using SongApi.Models;
using Microsoft.EntityFrameworkCore;

namespace SongApi.Data;

public class SongContext : DbContext {
    public SongContext(DbContextOptions<SongContext> options) : base(options)
    {

    }

    public DbSet<Song> Songs { get; set; }
    public DbSet<Category> Categories { get; set; }
}