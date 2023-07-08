using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Entities
{
    public class Poll : IEntity
    {

        public int Id { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public string? Token { get; set; }
        public ICollection<Question?> Questions { get; set; }

        //public List<Option>? Options { get; set; }
        //public List<Vote>? Votes { get; set; }

        //public int PollId { get; set; }
        //[Required]
        //public string Content { get; set; }
        //public ICollection<Question>? Questions { get; set; }
    }
}
