using SurveyApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Dto.Responses
{
    public class PollDisplayResponse
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public string? Token { get; set; }
        public ICollection<Question?> Questions { get; set; } = new List<Question>();
        public QuestionType QuestionTypes { get; set; }
        public VoteType VoteTypes { get; set; }

    }
}
