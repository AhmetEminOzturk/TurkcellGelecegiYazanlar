using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Dto.Requests
{
    public class UpdateOptionRequest
    {
        public int OptionId { get; set; }
        public string Content { get; set; }
        public bool IsMultipleChoice { get; set; } // True: Birden çok seçenek seçilebilir , False: Tek seçenek seçilebilir
        public int? QuestionId { get; set; }
        public int? PollId { get; set; }
    
    }
}
