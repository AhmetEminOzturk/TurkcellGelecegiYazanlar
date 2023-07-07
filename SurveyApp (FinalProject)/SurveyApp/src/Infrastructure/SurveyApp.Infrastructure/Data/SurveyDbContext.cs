using Microsoft.EntityFrameworkCore;
using SurveyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Infrastructure.Data
{
    public class SurveyDbContext: DbContext
    {
        public SurveyDbContext(DbContextOptions<SurveyDbContext> options) : base(options) { }

        public DbSet<Vote> Votes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Poll> Polls { get; set; }
        public DbSet<Option> Options { get; set; }
             
    }
}
