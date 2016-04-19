using Data.Mapping;
using Entities;
using System.Data.Entity;

namespace Data.Context
{

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("DataContextConnection")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new UserTypeMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
