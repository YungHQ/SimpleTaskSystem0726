using Abp.Web.Mvc.Views;

namespace SimpleTaskSystem0726.Web.Views
{
    public abstract class SimpleTaskSystem0726WebViewPageBase : SimpleTaskSystem0726WebViewPageBase<dynamic>
    {

    }

    public abstract class SimpleTaskSystem0726WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SimpleTaskSystem0726WebViewPageBase()
        {
            LocalizationSourceName = SimpleTaskSystem0726Consts.LocalizationSourceName;
        }
    }
}