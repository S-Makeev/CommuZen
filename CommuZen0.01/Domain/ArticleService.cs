using CommuZen0._01.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommuZen0._01.Domain
{
    public class ArticleService : IArticleService
    {
        public async Task<int> Create(ArticleEntity entity)
        {
            return 1;
        }

        public List<ArticleEntity> GetAll()
        {
            var collection = new List<ArticleEntity>();
            collection.Add(new ArticleEntity { Body = "Service", Header = "Article", Id = 1 });
            return collection;
        }
    }
}
