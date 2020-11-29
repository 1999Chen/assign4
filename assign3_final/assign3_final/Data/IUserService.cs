﻿using System.Threading.Tasks;

namespace assign3_final.Data
{
    public interface IUserService
    {

        Task<string> validateUser(string username, string password);
        
        

    }
}