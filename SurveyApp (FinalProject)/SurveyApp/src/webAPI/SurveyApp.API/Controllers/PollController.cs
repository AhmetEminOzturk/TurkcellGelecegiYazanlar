using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyApp.Dto.Requests;
using SurveyApp.Services;

namespace SurveyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PollController : ControllerBase
    {
        private readonly IPollService _pollService;

        public PollController(IPollService pollService)
        {
            _pollService = pollService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPolls()
        {
            var polls = await _pollService.GetAllPollsAsync();
            return Ok(polls);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPollsById(int id)
        {
            var polls = await _pollService.GetPollByIdAsync(id);
            if (polls == null)
            {
                return NotFound();
            }
            return Ok(polls);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePoll(CreateNewPollRequest createNewPollRequest)
        {
            await _pollService.CreatePollAsync(createNewPollRequest);                     
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePoll(UpdatePollRequest updatePollRequest)
        {
            await _pollService.UpdatePollAsync(updatePollRequest);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePoll(int id)
        {
            await _pollService.DeletePollAsync(id);
            return Ok();
        }
    }
}
