using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Entities
{
    public class Option : IEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int? QuestionId { get; set; }
        public Question? Question { get; set; }

        public ICollection<Vote?> Votes { get; set; }

        public int? PollId { get; set; }
        public Poll? Poll { get; set; }
    }
}
