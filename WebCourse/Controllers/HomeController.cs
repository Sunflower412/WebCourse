using Microsoft.AspNetCore.Mvc;
using WebCourse.Data.Interfaces;

namespace WebCourse.Controllers
{
    public class HomeController : Controller
    {
        private IAllAbillities _abillityRep;

        public HomeController(IAllAbillities abillityRep)
        {
            _abillityRep = abillityRep;
        }

        public ViewResult Index()
        {
            return View();
        }
    }
}
