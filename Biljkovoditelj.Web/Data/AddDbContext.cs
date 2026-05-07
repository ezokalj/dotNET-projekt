using Microsoft.EntityFrameworkCore;
using Biljkovoditelj.model.Entities;

public class AddDbContext : DbContext
{
    public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) { }

    // DbSet properties for all entities
    public DbSet<Plant> Plants { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<CareTask> CareTasks { get; set; }
    public DbSet<Reminder> Reminders { get; set; }
    public DbSet<WateringLog> WateringLogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure Plant entity relationships
        modelBuilder.Entity<Plant>()
            .HasOne(p => p.Room)
            .WithMany(r => r.Plants)
            .HasForeignKey(p => p.RoomId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Plant>()
            .HasOne(p => p.User)
            .WithMany(u => u.Plants)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        // Configure CareTask relationships
        modelBuilder.Entity<CareTask>()
            .HasOne(ct => ct.Plant)
            .WithMany(p => p.CareTasks)
            .HasForeignKey(ct => ct.PlantId)
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Reminder relationships
        modelBuilder.Entity<Reminder>()
            .HasOne(r => r.Plant)
            .WithMany(p => p.Reminders)
            .HasForeignKey(r => r.PlantId)
            .OnDelete(DeleteBehavior.Cascade);

        // Configure WateringLog relationships
        modelBuilder.Entity<WateringLog>()
            .HasOne(wl => wl.Plant)
            .WithMany(p => p.WateringLogs)
            .HasForeignKey(wl => wl.PlantId)
            .OnDelete(DeleteBehavior.Cascade);

        // Index for better query performance
        modelBuilder.Entity<Plant>().HasIndex(p => p.RoomId);
        modelBuilder.Entity<Plant>().HasIndex(p => p.UserId);
        modelBuilder.Entity<CareTask>().HasIndex(ct => ct.PlantId);
        modelBuilder.Entity<Reminder>().HasIndex(r => r.PlantId);
        modelBuilder.Entity<WateringLog>().HasIndex(wl => wl.PlantId);
    }
}