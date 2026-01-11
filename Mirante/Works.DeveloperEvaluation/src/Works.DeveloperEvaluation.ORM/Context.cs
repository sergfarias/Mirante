using Works.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Works.DeveloperEvaluation.ORM;

public class Context : DbContext
{
    
    public DbSet<Tarefa> Tarefa { get; set; }
  
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarefa>().ToTable("Tarefa");
    }
}
