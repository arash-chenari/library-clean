using Library.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Persistence.EF.Categories
{
    public class CategoryEntityMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(c => c.Id);
            builder.Property(_ => _.Id)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

            builder.Ignore(_ => _.AgeRange);

            builder.Property(_ => _.Title)
                .HasMaxLength(50);
        }
    }
}
