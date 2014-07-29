using Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Models
{
    public class UserController : ApiController
    {
        private UserRepository _userRepository;

        public UserController()
        {
        }

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Get()
        {
            return _userRepository.Get();
        }
    
    }
}
