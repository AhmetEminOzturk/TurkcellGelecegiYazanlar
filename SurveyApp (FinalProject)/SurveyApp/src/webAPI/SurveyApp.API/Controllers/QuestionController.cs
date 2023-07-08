using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyApp.Dto.Requests;
using SurveyApp.Services;

namespace SurveyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
    
        [HttpGet]
        public async Task<IActionResult> GetAllQuestions()
        {
            var question = await _questionService.GetAllQuestionsAsync();
            return Ok(question);
        }


        [HttpPost]
        public async Task<IActionResult> CreateQuestion(CreateNewQuestionRequest createNewQuestionRequest)
        {
            await _questionService.CreateQuestionAsync(createNewQuestionRequest);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateQuestion(UpdateQuestionRequest updateQuestionRequest)
        {
            await _questionService.UpdateQuestionAsync(updateQuestionRequest);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            await _questionService.DeleteQuestionAsync(id);
            return Ok();
        }
    }
}
