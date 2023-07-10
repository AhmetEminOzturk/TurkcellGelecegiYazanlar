using AutoMapper;
using SurveyApp.Dto.Requests;
using SurveyApp.Entities;
using SurveyApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services
{
    public class VoteService : IVoteService
    {
        private readonly IVoteRepository _voteRepository;
        private readonly IMapper _mapper;

        public VoteService(IVoteRepository voteRepository, IMapper mapper)
        {
            _voteRepository = voteRepository;
            _mapper = mapper;
        }

        public async Task CreateVoteAsync(CreateNewVoteRequest createNewVoteRequest)
        {
            var user = _mapper.Map<Vote>(createNewVoteRequest);
            await _voteRepository.CreateAsync(user);
        }
    }
}
