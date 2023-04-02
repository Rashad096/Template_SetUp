using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Template_HomeWork.Models;
using Template_HomeWork.ViewModels;

namespace Template_HomeWork.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModels team = new HomeViewModels
            {
                Members = Data.Members
            };
            return View(team);
        }


        public IActionResult Detail(int id)
        {
            Team members = Data.Members.Find(x => x.Id == id);
            return View(members);
        }
    }
}
