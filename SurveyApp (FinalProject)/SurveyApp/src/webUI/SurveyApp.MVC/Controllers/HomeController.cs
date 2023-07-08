using Microsoft.AspNetCore.Mvc;
using SurveyApp.MVC.Models;
using SurveyApp.Services;
using System.Diagnostics;

namespace SurveyApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPollService _pollService;

        public HomeController(ILogger<HomeController> logger, IPollService pollService)
        {
            _logger = logger;
            _pollService = pollService;
        }

        public async Task<IActionResult> Index()
        {
            var polls = await _pollService.GetAllPollsWithQestionsAndOptionsAsync();
            return View(polls);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}