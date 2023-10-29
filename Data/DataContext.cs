using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}

    public DbSet<Location> Locations { get; set; }
}