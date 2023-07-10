using SurveyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Dto.Requests
{
    public class CreateNewVoteRequest
    {
        public int Id { get; set; }

        public int? PollId { get; set; }
        public Poll? Poll { get; set; }

        public int? OptionId { get; set; }
        public Option? Option { get; set; }

        public int? QuestionId { get; set; }
        public Question? Question { get; set; }

        public string Content { get; set; }
        public bool IsSelected { get; set; }
    }
}
