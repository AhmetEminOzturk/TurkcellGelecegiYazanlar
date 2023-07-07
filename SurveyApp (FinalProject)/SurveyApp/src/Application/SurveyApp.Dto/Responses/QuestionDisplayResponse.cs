using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Dto.Responses
{
    public class QuestionDisplayResponse
    {
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public int PollId { get; set; }
        
    }
}
