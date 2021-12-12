﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Manager.services.DTO;

namespace Manager.services.Interfaces
{
    public interface IUserService
    {
        public interface IUserService
        {
            Task<UserDTO> Create(UserDTO userDTO);
            Task<UserDTO> Update(UserDTO userDTO);
            Task Remove(long id);
            Task<UserDTO> Get(long id);
            Task<List<UserDTO>> Get();
            Task<List<UserDTO>> SearchByName(string name);
            Task<List<UserDTO>> SearchByEmail(string email);
            Task<UserDTO> GetByEmail(string email);
        }
    }
}
