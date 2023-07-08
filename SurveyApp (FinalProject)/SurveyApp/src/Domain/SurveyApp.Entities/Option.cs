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
        //public bool IsMultipleChoice { get; set; } // True: Birden çok seçenek seçilebilir , False: Tek seçenek seçilebilir

        public int? QuestionId { get; set; }
        public Question? Question { get; set; }

        //public int? VoteId { get; set; }
        //public Vote? Votes { get; set; }

        public int? PollId { get; set; }
        public Poll? Poll { get; set; }
    }
}
