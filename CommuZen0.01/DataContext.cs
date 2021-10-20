using CommuZen0._01.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CommuZen0._01
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<UserChatEntity> UserChats { get; set; }
        public DbSet<ChatEntity> Chats { get; set; }
        public DbSet<VacancyEntity> Vacancies { get; set; }
    }
}