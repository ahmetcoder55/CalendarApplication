using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Repositories.Abstract
{
    public interface IUserDal:IGenericRepository<User>
    {
        Task<User?> GetByUsernameAsync(string username);

        Task<bool> EmailExistsAsync(string email);
    }
}
