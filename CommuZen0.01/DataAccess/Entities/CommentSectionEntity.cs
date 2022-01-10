using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommuZen0._01.DataAccess.Entities
{
    public class CommentSectionEntity : BaseEntity
    {
        public long? UserId { get; set; }
        public string Comment { get; set; }
        public long? ArticleId { get; set; }
        public UserEntity User { get; set; }
        public ArticleEntity Article { get; set; }
    }
}
