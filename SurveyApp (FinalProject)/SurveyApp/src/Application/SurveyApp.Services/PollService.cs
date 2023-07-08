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
    public class PollService : IPollService
    {
        private readonly IPollRepository _pollRepository;
        private readonly IMapper _mapper;

        public PollService(IPollRepository pollRepository, IMapper mapper)
        {
            _pollRepository = pollRepository;
            _mapper = mapper;
        }

        public async Task CreatePollAsync(CreateNewPollRequest createNewPollRequest)
        {
            var poll = _mapper.Map<Poll>(createNewPollRequest);
            await _pollRepository.CreateAsync(poll);
              
        }

        public async Task DeletePollAsync(int id)
        {
            await _pollRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<PollDisplayResponse>> GetAllPollsAsync()
        {
            var polls = await _pollRepository.GetAllAsync();
            var response = _mapper.Map<IEnumerable<PollDisplayResponse>>(polls);
            return response;
        }

        public async Task<IEnumerable<PollDisplayResponse>> GetAllPollsWithQestionsAndOptionsAsync()
        {
            var polls = await _pollRepository.GetAllWithQuestionsAndOptionsAsync();
            var response = _mapper.Map<IEnumerable<PollDisplayResponse>>(polls);
            return response;
        }

        public async Task<PollDisplayResponse> GetPollByIdAsync(int id)
        {
            var poll = await _pollRepository.GetAsync(id);
            return _mapper.Map<PollDisplayResponse>(poll);
        }

        public async Task UpdatePollAsync(UpdatePollRequest updatePollRequest)
        {
            var poll = _mapper.Map<Poll>(updatePollRequest);
            await _pollRepository.UpdateAsync(poll);
        }
    }
}
