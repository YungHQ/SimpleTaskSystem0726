using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace SimpleTaskSystem0726
{
    [DependsOn(typeof(SimpleTaskSystem0726CoreModule),typeof(AbpAutoMapperModule))]
    public class SimpleTaskSystem0726ApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                DtoMappings.Map(mapper);
            });
        }
    }
}
