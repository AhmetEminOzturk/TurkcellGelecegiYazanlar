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
    public class OptionService : IOptionService
    {
        private readonly IOptionRepository _optionRepository;
        private readonly IMapper _mapper;

        public OptionService(IOptionRepository optionRepository, IMapper mapper)
        {
            _optionRepository = optionRepository;
            _mapper = mapper;
        }

        public async Task CreateOptionAsync(CreateNewOptionRequest createNewOptionRequest)
        {
            var option = _mapper.Map<Option>(createNewOptionRequest);
            await _optionRepository.CreateAsync(option);
        }

        public async Task DeleteOptionAsync(int id)
        {
            await _optionRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<OptionDisplayResponse>> GetAllOptionsAsync()
        {
            var options = await _optionRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<OptionDisplayResponse>>(options);
        }

        public async Task<OptionDisplayResponse> GetOptionAsync(int id)
        {
            var option = await _optionRepository.GetAsync(id);
            return _mapper.Map<OptionDisplayResponse>(option);
        }

        public async Task UpdateOptionAsync(UpdateOptionRequest updateOptionRequest)
        {
            var option = _mapper.Map<Option>(updateOptionRequest);
            await _optionRepository.UpdateAsync(option);
        }
    }
}
