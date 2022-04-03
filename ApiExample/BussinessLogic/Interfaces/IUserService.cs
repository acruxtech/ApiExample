using ApiExample.BussinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.BussinessLogic.Interfaces
{
    public interface IUserService
    {
        Task<string> Auth(UserIdentityBlo userIdentityBlo);
        Task<string> Register(UserIdentityBlo userIdentityBlo);
        Task<UserInformationBlo> Get(int id);
        Task<UserInformationBlo> Update(UserUpdateBlo userUpdateBlo, string token);
        Task<bool> IsExistEmail(string email);
        Task<bool> IsExistLogin(string login);
    }
}
