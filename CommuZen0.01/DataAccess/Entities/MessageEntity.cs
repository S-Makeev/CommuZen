namespace CommuZen0._01.DataAccess.Entities
{
    public class MessageEntity : BaseEntity
    {
        public string Message { get; set; }
        public long? UserId { get; set; }
        public UserEntity User { get; set; }
        public long? ChatId { get; set; }
        public ChatEntity Chat { get; set; }
    }
}