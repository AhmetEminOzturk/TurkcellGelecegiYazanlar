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
    public class EFPollRepository : IPollRepository
    {
        private readonly SurveyDbContext _context;

        public EFPollRepository(SurveyDbContext context)
        {
            _context = context;
        }

        public void Create(Poll entity)
        {
            _context.Polls.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(Poll entity)
        {
            await _context.Polls.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Polls.Find(id);
            _context.Polls.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Polls.FindAsync(id);
            _context.Polls.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public Poll? Get(int id)
        {
            return _context.Polls.SingleOrDefault(x => x.PollId == id);
        }

        public IList<Poll?> GetAll()
        {
            return _context.Polls.AsNoTracking().ToList();
        }

        public async Task<IList<Poll?>> GetAllAsync()
        {
            return await _context.Polls.AsNoTracking().ToListAsync();
        }

        public async Task<Poll?> GetAsync(int id)
        {
            return await _context.Polls.AsNoTracking().FirstOrDefaultAsync(p => p.PollId == id);
        }

        public void Update(Poll entity)
        {
            _context.Polls.Update(entity);
            _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Poll entity)
        {
            _context.Polls.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
