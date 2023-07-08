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
    public class EFVoteRepository : IVoteRepository
    {
        private readonly SurveyDbContext _context;

        public EFVoteRepository(SurveyDbContext context)
        {
            _context = context;
        }

        public void Create(Vote entity)
        {
            _context.Votes.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(Vote entity)
        {
            await _context.Votes.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Votes.Find(id);
            _context.Votes.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Votes.FindAsync(id);
            _context.Votes.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public Vote? Get(int id)
        {
            return _context.Votes.SingleOrDefault(x => x.Id == id);
        }

        public IList<Vote?> GetAll()
        {
            return _context.Votes.AsNoTracking().ToList();
        }

        public async Task<IList<Vote?>> GetAllAsync()
        {
            return await _context.Votes.AsNoTracking().ToListAsync();
        }

        public async Task<Vote?> GetAsync(int id)
        {
            return await _context.Votes.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public void Update(Vote entity)
        {
            _context.Votes.Update(entity);
            _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Vote entity)
        {
            _context.Votes.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
