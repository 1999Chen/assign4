﻿using System;
using System.Threading.Tasks;
using assign3_final.DataAccess;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace assign3_final.Data
{
    public class userService:IUserService
    {
        aDBContext dbcontext = new aDBContext();
        
        public async Task<string> validateUser(string username, string password)
        {
            Console.WriteLine("serverValidate1");
            User user = await dbcontext.User.FirstAsync(c => c.UserName==username);
            if (user==null)
            {
                return "N";
            }
            if (user.Password==password)
            {
                return "T";
            }
            return "F";
            
            
        }
    }
}