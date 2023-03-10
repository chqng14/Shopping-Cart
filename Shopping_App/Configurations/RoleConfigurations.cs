using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Shopping_App.Models;

namespace Shopping_App.Configurations
{
    public class RoleConfigurations : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("VaiTro"); // Dat ten cho bang
            builder.HasKey(x => x.RoleID);
            builder.Property(x=>x.RoleName).HasColumnType("nvarchar(100000)").IsRequired();
            builder.Property(x=>x.Description).HasColumnType("nvarchar(10000)").IsRequired();
            builder.Property(x=>x.Status).HasColumnType("int").IsRequired();

        }
    }
}
