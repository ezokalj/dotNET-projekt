using Microsoft.EntityFrameworkCore;
using Biljkovoditelj.model.Entities;

public class AddDbContext : DbContext
{
    public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) { }

    public DbSet<Plant> Plants { get; set; }
    public DbSet<Room> Rooms { get; set; }
}