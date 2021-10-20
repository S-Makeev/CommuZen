using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommuZen0._01.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CommuZen0._01.Domain
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<long> Create(UserEntity userEntity)
        {
            var result = await _context.Users.AddAsync(userEntity);
            await _context.SaveChangesAsync();
            
            return result.Entity.Id;
        }

        public List<UserEntity> GetAll() => _context.Users.Include(x => x.Articles).ToList();

        public async Task<UserEntity> GetById(long id)
        {
            var user = await _context.Users
                .Include(x => x.Articles)
                .FirstOrDefaultAsync(x => x.Id == id);

            return user;
        }
        
        public async Task<long> Update(UserEntity userEntity)
        {
            var result = _context.Users.Update(userEntity);
            await _context.SaveChangesAsync();

            
            return result.Entity.Id;
        }
        
        public async Task Remove(UserEntity userEntity)
        {
            _context.Users.Remove(userEntity);
            await _context.SaveChangesAsync();
        }
    }
}