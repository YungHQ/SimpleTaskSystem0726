using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace SimpleTaskSystem0726
{
    [DependsOn(typeof(AbpWebApiModule), typeof(SimpleTaskSystem0726ApplicationModule))]
    public class SimpleTaskSystem0726WebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(SimpleTaskSystem0726ApplicationModule).Assembly, "tasksystem")
                .Build();
        }
    }
}
