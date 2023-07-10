using AutoMapper;
using SurveyApp.Dto.Requests;
using SurveyApp.Dto.Responses;
using SurveyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Poll, PollDisplayResponse>();
            CreateMap<Question, QuestionDisplayResponse>();
            CreateMap<Option, OptionDisplayResponse>();
            CreateMap<User, UserDisplayResponse>();

            CreateMap<CreateNewPollRequest, Poll>().ReverseMap();
            CreateMap<CreateNewOptionRequest, Option>().ReverseMap();
            CreateMap<CreateNewQuestionRequest, Question>().ReverseMap();
            CreateMap<CreateNewUserRequest, User>().ReverseMap();
            CreateMap<CreateNewVoteRequest, Vote>().ReverseMap();

            CreateMap<UpdatePollRequest, Poll>().ReverseMap();
            CreateMap<UpdateOptionRequest, Option>().ReverseMap();
            CreateMap<UpdateQuestionRequest, Question>().ReverseMap();
            CreateMap<UpdateUserRequest, User>().ReverseMap();
        }
    }
}
