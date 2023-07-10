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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task CreateUserAsync(CreateNewUserRequest createNewUserRequest)
        {
            var user = _mapper.Map<User>(createNewUserRequest);
            await _userRepository.CreateAsync(user);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserDisplayResponse>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserDisplayResponse>>(users);
        }

        public async Task UpdateUserAsync(UpdateUserRequest updateUserRequest)
        {
            var user = _mapper.Map<User>(updateUserRequest);
            await _userRepository.UpdateAsync(user);
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            var users = await _userRepository.GetAllAsync();
            return users.SingleOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
