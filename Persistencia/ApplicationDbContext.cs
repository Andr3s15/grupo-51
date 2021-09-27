using Microsoft.EntityFrameworkCore;
using Dominio;
namespace Persistencia
{
    public class ApplicationDbContext : DbContext
    {
    private const string connectionString = @"Data Source = localhost\sqlexpress;Initial catalog = Grupo51;Integrated Security = True";

    public DbSet<Persona> personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        if(!optionsBuilder.IsConfigured){
            optionsBuilder
            .UseSqlServer(connectionString);
        }
    }
    }

    
    
}