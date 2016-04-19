using Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.Mapping
{
    class UserTypeMapping: EntityTypeConfiguration<UserType>
    {
        public UserTypeMapping()
        {
            // Especificar el nombre de una tabla.
            this.Map(m => m.ToTable("UserTypes"));

            //UserId
            this.HasKey(u => u.UserTypeId);

            //FirstName
            this.Property(u => u.UserTypeName).IsRequired()
                .HasMaxLength(150);
        }

    }
}
