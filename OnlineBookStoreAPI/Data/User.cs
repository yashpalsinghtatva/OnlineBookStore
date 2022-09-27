﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreAPI.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }

        public UserType UserType { get; set; }
        public int UserTypeId { get; set; }
        public string UserPhoneNo { get; set; }

    }
}
