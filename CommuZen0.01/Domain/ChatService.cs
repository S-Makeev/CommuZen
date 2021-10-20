using CommuZen0._01.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CommuZen0._01.Domain
{
    public class ChatService : IChatService
    {
        private readonly DataContext _context;

        public ChatService(DataContext context)
        {
            _context = context;
        }

        public async Task<long> Create(ChatEntity entity)
        {
            var result = await _context.Chats.AddAsync(entity);
            await _context.SaveChangesAsync();

            return result.Entity.Id;
        }

        public List<ChatEntity> GetAll()
        {
            var collection = new List<ChatEntity>();
            collection.Add(new ChatEntity { Body = "Service", Header = "Chat", Id = 1 });
            return collection;
        }

        public async Task<List<UserEntity>> GetUsersByChat(long chatId)
        {
            var users = await _context.UserChats
                .Include(x => x.User)
                .ThenInclude(x => x.Articles)
                .Where(x => x.ChatId == chatId)
                .Select(x => x.User)
                .ToListAsync();

            return users;
        }
    }
}
