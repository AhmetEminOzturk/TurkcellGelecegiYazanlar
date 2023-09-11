using SurveyApp.Entities;

namespace SurveyApp.MVC.Models
{
    public class VoteViewModel
    {
        public int Id { get; set; }
        public int? PollId { get; set; }       
        public int? OptionId { get; set; }    
        public int? QuestionId { get; set; }      
        public string Content { get; set; }
        public bool IsSelected { get; set; }
    }
}
