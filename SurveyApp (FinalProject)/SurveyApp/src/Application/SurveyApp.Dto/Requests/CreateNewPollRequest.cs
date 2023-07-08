using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Dto.Requests
{
    public class CreateNewPollRequest
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public string? Token { get; set; }
    }
}
