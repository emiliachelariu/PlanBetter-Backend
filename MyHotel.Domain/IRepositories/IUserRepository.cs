using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Domain.IRepositories
{
    public interface IUserRepository:IBaseRepository<User>
    {
        public int GetUserByEmail(string email,string password);
    }
}
