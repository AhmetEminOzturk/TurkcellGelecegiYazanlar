using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Dto.Requests
{
    public class CreateNewQuestionRequest
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public int PollId { get; set; }
    }
}
