using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Dto.Responses
{
    public class PollDisplayResponse
    {
        public int PollId { get; set; }
        [Required]
        public string Content { get; set; }
        
    }
}
