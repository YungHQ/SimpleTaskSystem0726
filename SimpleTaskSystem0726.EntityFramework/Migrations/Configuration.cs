using System.Data.Entity.Migrations;
using SimpleTaskSystem.People;

namespace SimpleTaskSystem0726.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SimpleTaskSystem0726.EntityFramework.SimpleTaskSystem0726DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SimpleTaskSystem0726";
        }

        protected override void Seed(SimpleTaskSystem0726.EntityFramework.SimpleTaskSystem0726DbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
            context.People.AddOrUpdate(
                p => p.Name,
                new Person { Name = "Isaac Asimov" },
                new Person { Name = "Thomas More" },
                new Person { Name = "George Orwell" },
                new Person { Name = "Douglas Adams" }
            );
        }
    }
}
