using Abp.Application.Services;

namespace SimpleTaskSystem0726
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SimpleTaskSystem0726AppServiceBase : ApplicationService
    {
        protected SimpleTaskSystem0726AppServiceBase()
        {
            LocalizationSourceName = SimpleTaskSystem0726Consts.LocalizationSourceName;
        }
    }
}