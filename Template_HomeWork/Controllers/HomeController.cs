using Microsoft.AspNetCore.Mvc;
using Template_HomeWork.Models;
using Template_HomeWork.ViewModels;

namespace Template_HomeWork.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModels homeVM = new HomeViewModels
            {
                Services = Data.Services,
                Members=Data.Members
            };
            return View(homeVM);
        }

        public IActionResult Contact()
        {
            HomeViewModels ContactView = new HomeViewModels
            {
                Contacts = Data.Contacts
            };
            return View(ContactView);
        }
    }
}
