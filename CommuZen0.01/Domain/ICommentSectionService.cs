using CommuZen0._01.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommuZen0._01.Domain
{
   public interface ICommentSectionService
    {
        List<CommentSectionEntity> GetAll();
        Task<int> Create(CommentSectionEntity entity);
    }
}
