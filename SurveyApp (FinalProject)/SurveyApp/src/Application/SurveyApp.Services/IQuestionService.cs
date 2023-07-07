using SurveyApp.Dto.Requests;
using SurveyApp.Dto.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services
{
    public interface IQuestionService
    {
        Task<QuestionDisplayResponse> GetQuestionAsync(int id);
        Task<IEnumerable<QuestionDisplayResponse>> GetAllQuestionsAsync();
        Task CreateQuestionAsync(CreateNewQuestionRequest createNewQuestionRequest);
        Task UpdateQuestionAsync(UpdateQuestionRequest updateQuestionRequest);
        Task DeleteQuestionAsync(int id);
    }
}
