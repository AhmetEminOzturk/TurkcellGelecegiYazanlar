using Microsoft.EntityFrameworkCore;
using SurveyApp.Entities;
using SurveyApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Infrastructure.Repositories
{
    public class EFQuestionRepository : IQuestionRepository
    {
        private readonly SurveyDbContext _context;

        public EFQuestionRepository(SurveyDbContext context)
        {
            _context = context;
        }

        public void Create(Question entity)
        {
            _context.Questions.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(Question entity)
        {
            await _context.Questions.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Questions.Find(id);
            _context.Questions.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Questions.FindAsync(id);
            _context.Questions.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public Question? Get(int id)
        {
            return _context.Questions.SingleOrDefault(x => x.Id == id);
        }

        public IList<Question?> GetAll()
        {
            return _context.Questions.AsNoTracking().ToList();
        }

        public async Task<IList<Question?>> GetAllAsync()
        {
            return await _context.Questions.AsNoTracking().ToListAsync();
        }

        public async Task<Question?> GetAsync(int id)
        {
            return await _context.Questions.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public void Update(Question entity)
        {
            _context.Questions.Update(entity);
            _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Question entity)
        {
            _context.Questions.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
