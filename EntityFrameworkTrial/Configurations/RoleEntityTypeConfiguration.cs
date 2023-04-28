using EntityFrameworkTrial.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkTrial.Configurations
{
    public class RoleEntityTypeConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(p => p.Status).HasColumnType("VARCHAR(60)");
            builder.Property(p => p.Name).HasColumnType("NVARCHAR(80)");
            builder.Property(p => p.Id);
        }
    }
}
