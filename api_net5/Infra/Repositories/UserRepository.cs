using api_net5.Domain.Entities;
using api_net5.Infra.Context;
using api_net5.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_net5.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ModelContext _contex;
        public UserRepository(ModelContext context) : base(context)
        {
            _contex = context;
        }

        public async Task<User> GetByEmail(string email)
        {
            User oUser = await _contex.Users.Where(user => user.Email.ToUpper() == email.ToUpper()).AsNoTracking().FirstOrDefaultAsync();

            return oUser;
        }

        public async Task<List<User>> SearchByName(string name)
        {
            List<User> lUser = await _contex.Users.Where(user => user.Nome.ToUpper() == name.ToUpper()).AsNoTracking().ToListAsync();

            return lUser;
        }

    }
}
