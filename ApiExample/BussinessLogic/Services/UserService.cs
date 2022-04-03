using ApiExample.BussinessLogic.Interfaces;
using ApiExample.BussinessLogic.Models;
using ApiExample.DataAccess.Interfaces;
using ApiExample.DataAccess.Models;
using ApiExample.Shared.Exceptions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.BussinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IContext _context;
        private readonly IMapper _mapper;
        
        public UserService(IContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<string> Register(UserIdentityBlo userIdentityBlo)
        {
            string token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());

            UserRto user = new UserRto()
            {
                Email = userIdentityBlo.Email,
                Login = userIdentityBlo.Login,
                Password = userIdentityBlo.Password,
                Token = token
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return token;
        }

        public async Task<string> Auth(UserIdentityBlo userIdentityBlo)
        {
            UserRto user = await _context.Users.FirstOrDefaultAsync(h => (h.Email == userIdentityBlo.Email &&
                h.Password == userIdentityBlo.Password) || h.Login == userIdentityBlo.Login &&
                h.Password == userIdentityBlo.Password);

            if (user == null) throw new NotFound("Логин/почта или пароль введены неверно");

            return user.Token;
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

        public Task<UserInformationBlo> Update(UserUpdateBlo userUpdateBlo)
        {
            throw new NotImplementedException();
        }
    }
}
