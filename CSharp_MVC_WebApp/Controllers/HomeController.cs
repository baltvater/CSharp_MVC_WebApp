using System.Linq;
using System.Web.Mvc;

namespace CSharp_MVC_WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReverseString(string inputString) {
            var rev = inputString.ToCharArray().Reverse();
            var revString = string.Join(string.Empty, rev);
            return Json(revString, JsonRequestBehavior.AllowGet);
        }
    }
}