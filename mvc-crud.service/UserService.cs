using mvc_crud.data;
using mvc_crud.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_crud.service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        ///         
        /// </summary>
        public UserService()
        //public UserService(IUserRepository userRepository)
        {
            _userRepository = new UserRepository();
            //_userRepository = new UserInMemoryRepository();


            //_userRepository = userRepository;
        }

        public User Get()
        {
            return _userRepository.Get();
        }
    }
}
