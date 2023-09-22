using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Services.IServices
{
    public interface IUserService
    {
        public IEnumerable<User> GetAllUsers();
        public User GetUserbyId(int id);
        public int AddUser(UserModel model);
        public void Update(User user);
        public void Delete(int id);
        public int GetUserbyEmai(string email, string password);
    }
}
