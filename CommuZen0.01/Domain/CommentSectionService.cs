using CommuZen0._01.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommuZen0._01.Domain
{
    public class CommentSectionService : ICommentSectionService
    {
        public async Task<int> Create(CommentSectionEntity entity)
        {
            return 1;
        }

        public List<CommentSectionEntity> GetAll()
        {
            return null;
        }
    }
}
