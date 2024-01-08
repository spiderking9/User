using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserDomain.AggregateModels;

namespace UserData.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public static string SchemaName { get => UserContext.DEFAULT_SCHEMA; }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", SchemaName);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            builder.Property(p => p.Status)
                .IsRequired()
                .HasColumnType("bit");

            builder.Property(p => p.DateTime)
                .IsRequired();

            builder.Property(p => p.Email)
                .IsRequired()
                .HasColumnType("nvarchar(200)");

            builder.Property(p => p.Phone)
                .IsRequired()
                .HasColumnType("nvarchar(100)");
        }
    }
}