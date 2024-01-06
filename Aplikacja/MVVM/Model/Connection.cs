using Aplikacja.MVVM.Model;
using Microsoft.EntityFrameworkCore;

public class Connection : DbContext
{
    public DbSet<MenuTableSchema> Menu { get; set; } 
    public DbSet<ChildrenTableSchema> Childrens { get; set; }   
    public DbSet<MessageTableSchema> Message { get; set; }
    public DbSet<PresenceTableSchema> Presence { get; set; }
    public DbSet<UserTableSchema> User { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        optionsBuilder.UseNpgsql("Host=your_host;Port=your_port;Database=your_database;Username=your_username;Password=your_password");
    }
}
