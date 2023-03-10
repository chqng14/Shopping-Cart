using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shopping_App.Models;
namespace Shopping_App.Configurations
{
    public class CartConfiguratins : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("GioHang"); // Dat ten cho bang
            builder.HasKey(x => x.UserID);
            builder.Property(x=>x.Description).HasColumnType("nvarchar(10000)");

            builder.HasOne(c=>c.User).WithMany(c=>c.Carts).HasForeignKey(x => x.UserID);
        }
    }
}
