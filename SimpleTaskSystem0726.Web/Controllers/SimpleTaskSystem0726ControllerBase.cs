using Abp.Web.Mvc.Controllers;

namespace SimpleTaskSystem0726.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class SimpleTaskSystem0726ControllerBase : AbpController
    {
        protected SimpleTaskSystem0726ControllerBase()
        {
            LocalizationSourceName = SimpleTaskSystem0726Consts.LocalizationSourceName;
        }
    }
}