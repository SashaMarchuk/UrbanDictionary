﻿using System;
using System.Collections.Generic;
using UrbanDictionary.BusinessLayer.DTO;

namespace UrbanDictionary.BusinessLayer.Services.Contracts
{
    public interface IUserService
    {
        public IEnumerable<UserDTO> GetAll();
        public IEnumerable<UserDTO> GetByUserName(string name);
    }
}
