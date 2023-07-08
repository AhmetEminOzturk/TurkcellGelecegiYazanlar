using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyApp.Dto.Requests;
using SurveyApp.Services;

namespace SurveyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionController : ControllerBase
    {
        private readonly IOptionService _optionService;

        public OptionController(IOptionService optionService)
        {
            _optionService = optionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOptions()
        {
            var options = await _optionService.GetAllOptionsAsync();
            return Ok(options);
        }


        [HttpPost]
        public async Task<IActionResult> CreateOption(CreateNewOptionRequest createNewOptionRequest)
        {
            await _optionService.CreateOptionAsync(createNewOptionRequest);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOption(UpdateOptionRequest updateOptionRequest)
        {
            await _optionService.UpdateOptionAsync(updateOptionRequest);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOption(int id)
        {
            await _optionService.DeleteOptionAsync(id);
            return Ok();
        }
    }
}
