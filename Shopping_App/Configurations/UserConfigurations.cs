using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shopping_App.Models;
namespace Shopping_App.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("NguoiDung"); // Dat ten cho bang
            builder.HasKey(x => x.UserID);
            builder.Property(x=>x.Username).HasColumnType("nvarchar(10000)").IsRequired();
            builder.Property(x=>x.Password).HasColumnType("nvarchar(10000)").IsRequired();
            builder.Property(x => x.Role).HasColumnType("UNIQUEIDENTIFIER").IsRequired();
            builder.Property(x => x.Status).HasColumnType("int");

            builder.HasOne(x => x.Roles).WithMany(x => x.Users).HasForeignKey(x => x.Role);

        }
    }
}
