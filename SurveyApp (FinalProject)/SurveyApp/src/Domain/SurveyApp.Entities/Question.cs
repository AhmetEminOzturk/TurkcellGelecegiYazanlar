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
        public int QuestionId { get; set; }
        public string Content { get; set; }

        public  ICollection<Option>? Options { get; set; }
        public  ICollection<Vote>? Votes { get; set; }
        public int? PollId { get; set; }
        public Poll? Poll { get; set; }
    }
}
