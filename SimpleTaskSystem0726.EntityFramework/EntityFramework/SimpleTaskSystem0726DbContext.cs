using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using SimpleTaskSystem.People;
using SimpleTaskSystem.Tasks;

namespace SimpleTaskSystem0726.EntityFramework
{
    public class SimpleTaskSystem0726DbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        public virtual IDbSet<Task> Tasks { get; set; }

        public virtual IDbSet<Person> People { get; set; }

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SimpleTaskSystem0726DbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SimpleTaskSystem0726DataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SimpleTaskSystem0726DbContext since ABP automatically handles it.
         */
        public SimpleTaskSystem0726DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SimpleTaskSystem0726DbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public SimpleTaskSystem0726DbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
