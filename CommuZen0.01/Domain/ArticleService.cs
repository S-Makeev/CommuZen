using CommuZen0._01.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommuZen0._01.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CommuZen0._01.Domain
{
    public class ArticleService : IArticleService
    {
        private readonly DataContext _context;

        public ArticleService(DataContext context)
        {
            _context = context;
        }

        public async Task<long> Create(ArticleEntity entity)
        {
            var result = await _context.Articles.AddAsync(entity);
            await _context.SaveChangesAsync();
            
            return result.Entity.Id;
        }

        public async Task<List<ArticleEntity>> GetAll()
        {
            var articles = await _context.Articles.Include(x => x.User).ToListAsync();
            
            return articles;
        }
        
        public async Task<ArticleEntity> GetById(long id)
        {
            var article = await _context.Articles.Include(x => x.User).Include(x => x.CommentSections).FirstOrDefaultAsync(x => x.Id == id);

            if (article == null)
            {
                throw new EntityNotFoundException();
            }
            
            return article;
        }
    }
}
