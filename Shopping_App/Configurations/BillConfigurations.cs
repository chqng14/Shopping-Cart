using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shopping_App.Models;
namespace Shopping_App.Configurations
{
    public class BillConfigurations : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("HoaDon"); // Dat ten cho bang
            builder.HasKey(x => x.ID);//Khóa chính
            //Set các thuộc tính
            builder.Property(x => x.CreateDate).HasColumnType("Datetime").IsRequired(); // Date time not null
            builder.Property(x => x.Status).HasColumnType("int").IsRequired();

            builder.HasOne(x => x.User).WithMany(y => y.Bills).HasForeignKey(x => x.ID);
        }
    }
}
