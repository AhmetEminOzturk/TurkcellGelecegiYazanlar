using AutoMapper;
using SurveyApp.Dto.Requests;
using SurveyApp.Dto.Responses;
using SurveyApp.Entities;
using SurveyApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task CreateQuestionAsync(CreateNewQuestionRequest createNewQuestionRequest)
        {
            var question = _mapper.Map<Question>(createNewQuestionRequest);
            await _questionRepository.CreateAsync(question);
        }

        public async Task DeleteQuestionAsync(int id)
        {
            await _questionRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<QuestionDisplayResponse>> GetAllQuestionsAsync()
        {
            var questions = await _questionRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<QuestionDisplayResponse>>(questions);
        }


        public async Task<QuestionDisplayResponse> GetQuestionAsync(int id)
        {
            var question = await _questionRepository.GetAsync(id);
            return _mapper.Map<QuestionDisplayResponse>(question);
        }

        public async Task UpdateQuestionAsync(UpdateQuestionRequest updateQuestionRequest)
        {
            var question = _mapper.Map<Question>(updateQuestionRequest);
            await _questionRepository.UpdateAsync(question);
        }
    }
}
