using System.Collections.Generic;
using System.Threading.Tasks;
using CommuZen0._01.DataAccess.Entities;

namespace CommuZen0._01.Domain
{
    public interface IUserService
    {
        Task<long> Create(UserEntity userEntity);
        List<UserEntity> GetAll();
        Task<UserEntity> GetById(long id);
        Task<long> Update(UserEntity userEntity);
        Task Remove(UserEntity userEntity);
    }
}