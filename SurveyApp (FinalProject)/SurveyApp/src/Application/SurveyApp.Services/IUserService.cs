using SurveyApp.Dto.Requests;
using SurveyApp.Dto.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services
{
    public interface IUserService
    {      
        Task CreateUserAsync(CreateNewUserRequest createNewUserRequest);
        Task UpdateUserAsync(UpdateUserRequest updateUserRequest);
        Task DeleteOptionAsync(int id);
    }
}
