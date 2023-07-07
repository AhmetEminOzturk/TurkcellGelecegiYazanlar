using SurveyApp.Dto.Requests;
using SurveyApp.Dto.Responses;
using SurveyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services
{
    public interface IPollService
    {
        Task<PollDisplayResponse> GetPollAsync(int id);
        Task<IEnumerable<PollDisplayResponse>> GetAllPollsAsync();
        Task CreatePollAsync(CreateNewPollRequest createNewPollRequest);
        Task UpdatePollAsync(UpdatePollRequest updatePollRequest);
        Task DeletePollAsync(int id);


    }
}
