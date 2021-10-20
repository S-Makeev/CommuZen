namespace CommuZen0._01.DataAccess.Entities
{
    public class ArticleEntity : BaseEntity
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public long? UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
