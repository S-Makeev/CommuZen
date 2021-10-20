using System;
using System.Collections.Generic;

namespace CommuZen0._01.DataAccess.Entities
{
    public class UserEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public DateTime BirthDate { get; set; }
        public List<ArticleEntity> Articles { get; set; }
    }
}