using CommuZen0._01.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommuZen0._01.Domain
{
    public class ChatService : IChatService
    {
        public async Task<int> Create(ChatEntity entity)
        {
            return 1;
        }

        public List<ChatEntity> GetAll()
        {
            var collection = new List<ChatEntity>();
            collection.Add(new ChatEntity { Body = "Service", Header = "Chat", Id = 1 });
            return collection;
        }
    }
}
