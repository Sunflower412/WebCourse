using Microsoft.AspNetCore.Mvc;
using WebCourse.Data.Interfaces;
using WebCourse.Data.models;
using WebCourse.ViewModels;

namespace WebCourse.Controllers
{
    public class InfoController : Controller
    {
        private readonly IAllAbillities _allAbillities;
        private readonly IInformationCategory _informationCategory;

        public InfoController(IAllAbillities iAllAbillities, IInformationCategory iInformationCategory)
        {
            _allAbillities = iAllAbillities;
            _informationCategory = iInformationCategory;
        }

        public ViewResult List()
        {
         
                ViewBag.Title = "Главная страница";
                InfosListViewModel obj = new InfosListViewModel();
                obj.allInfos = _allAbillities.Infos;
                obj.currCategory = "Выберите информацию для изучения:";
                return View(obj);
            }
		public ViewResult Aim()
		{
            return View();
		}
		public ViewResult Tasks()
		{
			return View();
		}
		public ViewResult History()
		{
			return View();
		}
		public ViewResult Architecture()
		{
			return View();
		}
		public ViewResult Stack()
		{
			return View();
		}
		public ViewResult Communication()
		{
			return View();
		}
        public ViewResult SnakeGame()
        {
            return View();
        }
        public ViewResult Test()
        {
            return View();
        }
    }
    }

