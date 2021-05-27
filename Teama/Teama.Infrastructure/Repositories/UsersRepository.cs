using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teama.Domain.Entities;
using Teama.Domain.Repositories;
using Teama.Infrastructure.Persistence;
using Teama.Infrastructure.Persistence.Base;

namespace Teama.Infrastructure.Repositories
{
    public class UsersRepository : Repository<User>, IUserRepository
    {
        public UsersRepository(TeamaContext teamaContext):base(teamaContext)
        {

        }
        public async Task<User> Login(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LogOut()
        {
            throw new NotImplementedException();
        }
    }
}
