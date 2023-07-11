using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurveyApp.Dto.Requests;
using SurveyApp.Dto.Responses;
using SurveyApp.Entities;
using SurveyApp.MVC.Models;
using SurveyApp.Services;
using System.Diagnostics;
using System.Text.Json;

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

        public async Task<IActionResult> IndexById(int id)
        {
            var poll = await _pollService.GetPollByIdWithQuestionsAndOptionsAsync(id);

            if (poll == null)
            {
                return NotFound(); 
            }

            return View(new List<PollDisplayResponse> { poll });
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