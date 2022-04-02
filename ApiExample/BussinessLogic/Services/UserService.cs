using ApiExample.BussinessLogic.Interfaces;
using ApiExample.BussinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.BussinessLogic.Services
{
    public class UserService : IUserService
    {
        public Task<UserInformationBlo> Auth(UserIdentityBlo userIdentityBlo, out string token)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> isExistEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> isExistLogin(string login)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Register(UserIdentityBlo userIdentityBlo, out string token)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Update(UserUpdateBlo userUpdateBlo)
        {
            throw new NotImplementedException();
        }
    }
}
