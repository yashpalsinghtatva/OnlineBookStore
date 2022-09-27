using AutoMapper;
using OnlineBookStoreAPI.Data;
using OnlineBookStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreAPI.Helpers
{
    public class ApplicationMapper :Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<UserType, UserTypeDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
