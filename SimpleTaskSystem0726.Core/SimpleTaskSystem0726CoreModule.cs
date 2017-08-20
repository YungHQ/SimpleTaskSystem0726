using System.Reflection;
using Abp.Modules;

namespace SimpleTaskSystem0726
{
    public class SimpleTaskSystem0726CoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
