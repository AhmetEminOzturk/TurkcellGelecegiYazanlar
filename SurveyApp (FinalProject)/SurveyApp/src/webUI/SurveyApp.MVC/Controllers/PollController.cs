using Microsoft.AspNetCore.Mvc;
using SurveyApp.Dto.Requests;
using SurveyApp.Dto.Responses;
using SurveyApp.Entities;
using SurveyApp.Services;

namespace SurveyApp.MVC.Controllers
{
    public class PollController : Controller
    {
        private readonly IPollService _pollService;

        public PollController(IPollService pollService)
        {
            _pollService = pollService;
        }

        public async Task<IActionResult> GetPolls()
        {
            var polls = await _pollService.GetAllPollsWithQestionsAndOptionsAsync();
            return View(polls);
        }

        [HttpGet]
        public async Task<IActionResult> GetPollById(int id)
        {
            var poll = await _pollService.GetPollByIdWithQuestionsAndOptionsAsync(id);

            if (poll == null)
            {
                return NotFound();
            }
          
            return View(new List<PollDisplayResponse> { poll });
            
        }
     
    }
}
