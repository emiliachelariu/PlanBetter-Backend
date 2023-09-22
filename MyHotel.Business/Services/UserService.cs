using AutoMapper;
using PlanBetter.Business.Models;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public int AddUser(UserModel model)
        {
            var user = _userRepository.Add(_mapper.Map<User>(model));
            return user.Id;
        }

        public void Delete(int id)
        {
            _userRepository.Delete(_userRepository.GetById(id));
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.ListAll();
        }

        public int GetUserbyEmai(string email, string password)
        {
            var user = _userRepository.GetUserByEmail(email,password);
            return user;
        }

        public User GetUserbyId(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }
    }
}
