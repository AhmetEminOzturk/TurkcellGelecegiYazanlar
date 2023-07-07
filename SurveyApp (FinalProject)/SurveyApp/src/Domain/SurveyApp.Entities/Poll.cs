﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Entities
{
    public class Poll : IEntity
    {
        public int PollId { get; set; }
        [Required]
        public string Content { get; set; }
        public ICollection<Question>? Questions { get; set; }
    }
}