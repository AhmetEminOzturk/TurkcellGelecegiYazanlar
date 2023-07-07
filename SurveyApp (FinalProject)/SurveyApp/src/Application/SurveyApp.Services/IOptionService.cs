using SurveyApp.Dto.Requests;
using SurveyApp.Dto.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services
{
    public interface IOptionService
    {
        Task<OptionDisplayResponse> GetOptionAsync(int id);
        Task<IEnumerable<OptionDisplayResponse>> GetAllOptionsAsync();
        Task CreateOptionAsync(CreateNewOptionRequest createNewOptionRequest);
        Task UpdateOptionAsync(UpdateOptionRequest updateOptionRequest);
        Task DeleteOptionAsync(int id);
    }
}
