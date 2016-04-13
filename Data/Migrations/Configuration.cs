namespace Data.Migrations
{
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Data.Context;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //Fill UserTypes table
            var userTypesList = new List<UserType>
            {
                new UserType {UserTypeName = "Cliente", Description="Usuario de tipo cliente" },
                new UserType {UserTypeName = "Administrador", Description="Usuario de tipo administrador" }
            };

            userTypesList.ForEach(u => context.UserTypes.Add(u));
            context.SaveChanges();


            //Fill Users table
            var usersList = new List<User>();
            for (int i = 0; i < 10; i++)
            {
                int userType = (i % 2 == 0) ? 1 : 2;
                User newUser = new User("Juan " + i, "Alvarez " + i, userType);
                usersList.Add(newUser);
            }
            usersList.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}
