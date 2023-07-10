using SurveyApp.Dto.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services
{
    public interface IVoteService
    {
        Task CreateVoteAsync(CreateNewVoteRequest createNewVoteRequest);
    }
}
