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
    }
}