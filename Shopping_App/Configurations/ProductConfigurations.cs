using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shopping_App.Models;
namespace Shopping_App.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("SanPham"); // Dat ten cho bang
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Name).HasColumnType("nvarchar(10000)").IsRequired();
            builder.Property(p => p.Price).HasColumnType("int").IsRequired();
            builder.Property(p => p.AvailableQuantity).HasColumnType("int").IsRequired();
            builder.Property(p => p.Status).HasColumnType("int").IsRequired();
            builder.Property(p => p.Supplier).HasColumnType("nvarchar(10000)").IsRequired();
            builder.Property(p => p.Description).HasColumnType("nvarchar(1000)").IsRequired();
        }
    }
}
