﻿using SurveyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Infrastructure.Repositories
{
    public interface IPollRepository : IRepository<Poll>
    {
        Task<IList<Poll?>> GetAllWithQuestionsAndOptionsAsync();
        Task <Poll?> GetPollByIdWithQuestionsAndOptionsAsync(int id);
        Task <int> CreatePollReturnIdAsync(Poll entity);
    }
}
