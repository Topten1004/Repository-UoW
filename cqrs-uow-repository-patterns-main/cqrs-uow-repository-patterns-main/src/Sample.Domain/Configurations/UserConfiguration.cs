using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Domain.Entities;

namespace Sample.Domain.Configurations
{
    public class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(ci => ci.Id);
            builder.Property(ci => ci.Id).IsRequired();
            builder.Property(ci => ci.Name).IsRequired();
            builder.Property(ci => ci.Surname).IsRequired();
            builder.Property(ci => ci.MobilePhoneNumber).IsRequired();
        }
    }
}