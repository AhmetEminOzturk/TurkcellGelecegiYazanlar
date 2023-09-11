using SurveyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Dto.Responses
{
    public class VoteDisplayResponse
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsSelected { get; set; }
        public int? PollId { get; set; }
        public Poll? Poll { get; set; }
        public ICollection<Question?> Questions { get; set; } = new List<Question>();
        public ICollection<Poll?> Polls { get; set; } = new List<Poll>();  //Sonradan ekledin
        public QuestionType QuestionTypes { get; set; }
        public VoteType VoteTypes { get; set; }
    }
}
