using System.Web.Mvc;

namespace SimpleTaskSystem0726.Web.Controllers
{
    public class HomeController : SimpleTaskSystem0726ControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}