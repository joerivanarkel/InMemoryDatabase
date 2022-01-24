using Data;
using Microsoft.EntityFrameworkCore;

namespace Data;
public class Database : DbContext
{
    public Database(DbContextOptions<Database> options)
        : base(options)
    {
        FillSongTable();
    }
    public DbSet<Song> Playlist { get; set; }

    private void FillSongTable()
    {
        Playlist.Add(new Song() {Name = "The Flying Dutchman", Genre = Genre.Country, Length = 2});
        Playlist.Add(new Song() { Name = "The Game", Genre = Genre.Metal, Length = 4});
        Playlist.Add(new Song() { Name = "Holiday", Genre = Genre.Rock, Length = 8});
        this.SaveChanges();

    }
}