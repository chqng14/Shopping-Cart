using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shopping_App.Models;
namespace Shopping_App.Configurations
{
    public class CartDetailsConfigurations : IEntityTypeConfiguration<CartDetails>
    {
        public void Configure(EntityTypeBuilder<CartDetails> builder)
        {
            builder.ToTable("ChiTietGiohang"); // Dat ten cho bang
            builder.HasKey(x => x.ID);
            builder.Property(x => x.UserID).HasColumnType("UNIQUEIDENTIFIER");
            builder.Property(x=>x.IDSP).HasColumnType("UNIQUEIDENTIFIER");
            builder.Property(x => x.Quantity).HasColumnType("int");

            builder.HasOne(x=>x.Cart).WithMany(x=>x.CartDetails).HasForeignKey(x=>x.UserID);
            builder.HasOne(x => x.Product).WithMany(x => x.CartDetails).HasForeignKey(x => x.IDSP);


            
        
        }
    }
}
