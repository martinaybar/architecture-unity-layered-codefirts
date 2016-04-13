using System.Data.Entity;
using Data.Entities;

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
        }
    }
}
