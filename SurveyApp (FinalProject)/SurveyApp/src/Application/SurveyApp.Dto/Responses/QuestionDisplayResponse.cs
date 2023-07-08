using SurveyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Dto.Responses
{
    public class QuestionDisplayResponse
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public int PollId { get; set; }
        public ICollection<Option?> Options { get; set; }

    }
}
