using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;
using PlanBetter.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Persistance.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(PlanBetterDbContext planBetterDbContext) : base(planBetterDbContext)
        {

        }

        public int GetUserByEmail(string email, string password)
        {
            int user = 0;
            user = (from x in _dbContext.Users
                                where x.Email == email && x.Password == password
                                select x.isAdmin).FirstOrDefault();

            return user;
           
        }
    }
}
