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
    public class EFUserRepository : IUserRepository
    {
        private readonly SurveyDbContext _context;

        public EFUserRepository(SurveyDbContext context)
        {
            _context = context;
        }

        public void Create(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(User entity)
        {
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = _context.Users.Find(id);
            _context.Users.Remove(deleting);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _context.Users.FindAsync(id);
            _context.Users.Remove(deleting);
            await _context.SaveChangesAsync();
        }

        public User? Get(int id)
        {
            return _context.Users.SingleOrDefault(x => x.UserId == id);
        }

        public IList<User?> GetAll()
        {
            return _context.Users.AsNoTracking().ToList();
        }

        public async Task<IList<User?>> GetAllAsync()
        {
            return await _context.Users.AsNoTracking().ToListAsync();
        }

        public async Task<User?> GetAsync(int id)
        {
            return await _context.Users.AsNoTracking().FirstOrDefaultAsync(p => p.UserId == id);
        }

        public void Update(User entity)
        {
            _context.Users.Update(entity);
            _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User entity)
        {
            _context.Users.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
