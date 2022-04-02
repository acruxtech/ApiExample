using ApiExample.BussinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.BussinessLogic.Interfaces
{
    public interface IUserService
    {
        Task<UserInformationBlo> Auth(UserIdentityBlo userIdentityBlo, out string token);
        Task<UserInformationBlo> Register(UserIdentityBlo userIdentityBlo, out string token);
        Task<UserInformationBlo> Get(int id);
        Task<UserInformationBlo> Update(UserUpdateBlo userUpdateBlo);
        Task<bool> isExistEmail(string email);
        Task<bool> isExistLogin(string login);
    }
}
