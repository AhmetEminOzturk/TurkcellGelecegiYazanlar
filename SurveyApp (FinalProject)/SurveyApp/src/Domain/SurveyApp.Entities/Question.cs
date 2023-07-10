using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Entities
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public Poll Poll { get; set; }
        public int PollId { get; set; }
        public ICollection<Option?> Options { get; set; }
        public QuestionType? QuestionTypes { get; set; }
        public VoteType? VoteTypes { get; set; }
    }
}
