using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Mappings.Autores
{
    public class AutorMap : IEntityTypeConfiguration<Autor> {
        public void Configure(EntityTypeBuilder<Autor> builder) {           
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Nome).HasMaxLength(256);
        } 
    }
}
