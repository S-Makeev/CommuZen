using CommuZen0._01.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommuZen0._01.Domain
{
   public interface IChatService
    {
        List<ChatEntity> GetAll();
        Task<int> Create(ChatEntity entity);
    }
}
