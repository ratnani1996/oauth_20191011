using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Try2.DTOs;
using Try2.Entities;
using Try2.Helpers;
using Try2.Interfaces;

namespace Try2.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        private IMapper _mapper;

        public UserService(ApplicationDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsersModelDTO> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UsersModelDTO GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UsersEntityModel user, int id)
        {
            throw new NotImplementedException();
        }
    }
}
