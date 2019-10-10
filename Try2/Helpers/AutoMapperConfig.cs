using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Try2.DTOs;
using Try2.Entities;

namespace Try2.Helpers
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<UsersModelDTO, UsersEntityModel>();
            CreateMap<UsersEntityModel, UsersModelDTO>();
        }
    }
}
