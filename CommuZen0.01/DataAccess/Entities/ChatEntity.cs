using System.Collections.Generic;

namespace CommuZen0._01.DataAccess.Entities
{
    public class ChatEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public List<MessageEntity> Messages { get; set; }
    }
}
