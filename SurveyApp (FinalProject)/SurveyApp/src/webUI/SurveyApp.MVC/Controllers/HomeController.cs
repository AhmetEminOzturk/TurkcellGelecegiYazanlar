using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurveyApp.Dto.Requests;
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
        private readonly IVoteService _voteService;
        private readonly IQuestionService _questionService;
        private readonly IOptionService _optionService;


        public HomeController(ILogger<HomeController> logger, IPollService pollService, IVoteService voteService, IQuestionService questionService, IOptionService optionService)
        {
            _logger = logger;
            _pollService = pollService;
            _voteService = voteService;
            _questionService = questionService;
            _optionService = optionService;
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