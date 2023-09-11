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
        public string? Content { get; set; }
        public User? User { get; set; }
        public int? UserId { get; set; }
        public ICollection<Question?> Questions { get; set; }
        public ICollection<Vote?> Votes { get; set; }

    }
}
