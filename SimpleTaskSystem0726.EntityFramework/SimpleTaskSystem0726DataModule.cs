using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using SimpleTaskSystem0726.EntityFramework;

namespace SimpleTaskSystem0726
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(SimpleTaskSystem0726CoreModule))]
    public class SimpleTaskSystem0726DataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<SimpleTaskSystem0726DbContext>(null);
        }
    }
}
