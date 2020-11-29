using System;
using System.Threading.Tasks;
using assign3_final.Data;
using assign3_final.Models;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
    public class userController:ControllerBase
    {
        private IUserService UserService;
        
        public userController(IUserService userService)
        {
            UserService = userService;
        }
        
         
        [HttpPut]
        public IActionResult GetLogin(string username,string password)
        {
            try
            {
                User user = new User
                {
                    UserName = username,
                    Password = password,
                    Role = "Admin"
                };
                var result = UserService.validateUser(user.UserName, user.Password);
                Console.WriteLine(user.UserName);
                Console.WriteLine(result.GetAwaiter().GetResult());
                LoginStatus loginStatus = new LoginStatus();
                return Ok(loginStatus);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        
        
}
