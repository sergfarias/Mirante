using Microsoft.EntityFrameworkCore;
using Works.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Works.DeveloperEvaluation.ORM.Mapping;

public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
{
    public void Configure(EntityTypeBuilder<Tarefa> builder)
    {
        builder.ToTable("Tarefa");
        builder.HasKey(u => u.ID);
        builder.Property(u => u.ID).HasColumnType("int");
        builder.Property(u => u.Titulo).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Descricao).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Status).IsRequired();
        builder.Property(u => u.DataVencimento).IsRequired();
    }
}
