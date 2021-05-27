using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teama.Domain.Entities;
using Teama.Domain.Repositories.Base;

namespace Teama.Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> Login(string UserName, string Password);
        Task<bool> LogOut();

    }
}
