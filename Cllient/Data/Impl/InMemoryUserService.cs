using System;
using System.Collections.Generic;
using System.Linq;
using Assignment.Models;

namespace Assignment.Data.Impl {
public class InMemoryUserService : IUserService {
    private List<User> users;

    public InMemoryUserService() {
        users = new[] {
            new User {
                Password = "123456",
                Role = "Manager",
                UserName = "Manager"
            },
            new User {
                Password = "123456",
                Role = "Guest",
                UserName = "Guest"
            },
            new User {
                Password = "123456",
                Role = "Admin",
                UserName = "Admin"
            }
        }.ToList();
    }


    public User ValidateUser(string userName, string password)
    {

        
        User user = new User {UserName = userName, Password = password, Role = "Admin"};

        Console.WriteLine("InMemoryUserService1");
        string result=ClientModel.getInstance().loginAdd(userName, password);

        if (result == "N") {
            throw new Exception("User not found");
        }
        
        if (result=="F") {
            throw new Exception("Incorrect password");
        }

        
            Console.WriteLine("InMemoryUserService2");
            return user;
        
        
    }
}
}