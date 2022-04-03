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

        public async Task<UserInformationBlo> Get(int id)
        {
            UserRto user = await _context.Users.FirstOrDefaultAsync(h => h.Id == id);

            if (user == null) throw new NotFound("Пользователя с таким id нет");

            return _mapper.Map<UserInformationBlo>(user);
        }

        public async Task<bool> IsExistEmail(string email)
        {
            UserRto user = await _context.Users.FirstOrDefaultAsync(h => h.Email == email);

            if (user == null) return false;

            return true;
        }

        public async Task<bool> IsExistLogin(string login)
        {
            UserRto user = await _context.Users.FirstOrDefaultAsync(h => h.Login == login);

            if (user == null) return false;

            return true;
        }

        public async Task<UserInformationBlo> Update(UserUpdateBlo userUpdateBlo, string token)
        {
            UserRto user = await _context.Users.FirstOrDefaultAsync(h => h.Token == token);

            if (user == null) throw new NotFound("Пользователя с таким токеном нет");

            user.Login = userUpdateBlo.Login;
            user.Email = userUpdateBlo.Email;

            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return _mapper.Map<UserInformationBlo>(user);
        }
    }
}
