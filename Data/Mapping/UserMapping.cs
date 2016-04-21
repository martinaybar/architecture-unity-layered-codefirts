using Entities;
using System.Data.Entity.ModelConfiguration;


namespace Data.Mapping
{
    class UserMapping: EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            // Especificar el nombre de una tabla.
            this.Map(m => m.ToTable("Users"));

            //UserId
            this.HasKey(u => u.UserId);

            //FirstName
            this.Property(u => u.FirstName).IsRequired()
                .HasMaxLength(150);

            //LastName
            this.Property(u => u.LastName).IsRequired()
                .HasMaxLength(150);

            //UserTypeId
            this.Property(u => u.UserTypeId).IsRequired();
            
            //UserName
            this.Property(c => c.UserName).HasMaxLength(50);

            //ForeingKey
            this.HasRequired(u => u.UserType)
                .WithMany(b => b.Users)
                .HasForeignKey(u => u.UserTypeId);

            //RowVersion
            this.Property(u => u.RowVersion).IsConcurrencyToken();
        }


    }
}
