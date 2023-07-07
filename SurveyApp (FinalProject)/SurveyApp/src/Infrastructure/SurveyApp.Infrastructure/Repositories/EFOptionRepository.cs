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
    public class EFOptionRepository : IOptionRepository
    {
        private readonly SurveyDbContext _context;

        public EFOptionRepository(SurveyDbContext context)
        {
            _context = context;
        }

        public void Create(Option entity)
        {
            _context.Options.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(Option entity)
        {
            await _context.Options.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Options.Find(id);
            _context.Options.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Options.FindAsync(id);
            _context.Options.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public Option? Get(int id)
        {
            return _context.Options.SingleOrDefault(x => x.OptionId == id);
        }

        public IList<Option?> GetAll()
        {
            return _context.Options.AsNoTracking().ToList();
        }

        public async Task<IList<Option?>> GetAllAsync()
        {
            return await _context.Options.AsNoTracking().ToListAsync();
        }

        public async Task<Option?> GetAsync(int id)
        {
            return await _context.Options.AsNoTracking().FirstOrDefaultAsync(p => p.OptionId == id);
        }

        public void Update(Option entity)
        {
            _context.Options.Update(entity);
            _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Option entity)
        {
            _context.Options.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
