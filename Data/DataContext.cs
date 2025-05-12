using APIDatingApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIDatingApp.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}