using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Try2.DTOs;
using Try2.Entities;

namespace Try2.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UsersModelDTO> GetAllUsers();

        UsersModelDTO GetUserById(int id);

        void DeleteUser(int id);

        void UpdateUser(UsersEntityModel user, int id);


    }
}
