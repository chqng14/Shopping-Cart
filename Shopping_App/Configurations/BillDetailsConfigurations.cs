using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shopping_App.Models;
namespace Shopping_App.Configurations
{
    public class BillDetailsConfigurations : IEntityTypeConfiguration<BillDetails>
    {
        public void Configure(EntityTypeBuilder<BillDetails> builder)
        {
            builder.ToTable("HoaDonChiTiet"); // Dat ten cho bang
            builder.HasKey(p => p.ID);
            //Set thuộc tính
            builder.Property(p => p.Price).HasColumnType("int").IsRequired();
            builder.Property(p => p.Quantity).HasColumnType("int").IsRequired();
            builder.Property(x => x.IDSP).HasColumnType("UNIQUEIDENTIFIER");
            builder.Property(x => x.IDHD).HasColumnType("UNIQUEIDENTIFIER");
            //set khóa ngoại
            builder.HasOne(x => x.Bill).WithMany(y => y.BillDetails).HasForeignKey(x => x.IDHD);
            builder.HasOne(x => x.Product).WithMany(y => y.BillDetails).HasForeignKey(x => x.IDSP);
        }
    }
}
