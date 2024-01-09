using Aplikacja.MVVM.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

public class Connection : DbContext
{
    public DbSet<MenuTableSchema> Menu { get; set; } 
    public DbSet<ChildrenTableSchema> Childrens { get; set; }   
    public DbSet<MessageTableSchema> Message { get; set; }
    public DbSet<PresenceTableSchema> Presence { get; set; }
    public DbSet<UserTableSchema> User { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("Core/dbsettings.json").Build();

        string? host = configuration.GetConnectionString("PostgreSQLHost");
        string? port = configuration.GetConnectionString("PostgreSQLPort");
        string? database = configuration.GetConnectionString("PostgreSQLDatabase");
        string? username = configuration.GetConnectionString("PostgreSQLUsername");
        string? password = configuration.GetConnectionString("PostgreSQLPassword");

        optionsBuilder.UseNpgsql($"Host={host};Port={port};Database={database};Username={username};Password={password}");
    }
}
