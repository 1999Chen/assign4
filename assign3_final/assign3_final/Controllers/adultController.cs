using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using assign3_final.Data;
using Microsoft.AspNetCore.Mvc;
using Models;

[ApiController]
[Route("[controller]")]
public class adultController : ControllerBase
{
    private IAdultService AdultService;


    public adultController(IAdultService adultService)
    {
        AdultService = adultService;
    }

    
    [HttpPut]
    public IActionResult AddAdult([FromBody] Adult adult)
    {
        Console.WriteLine("y u're wrong");
        try
        {
            
            Console.WriteLine(adult.id);
            AdultService.AddAdultAsync(adult);
            
            // Adult adult1 = new Adult()
            // {
            //     id = 11,
            //     age = 50,
            //     eyeColor = "Blue",
            //     hairColor = "Black",
            //     firstName = "theSixth",
            //     lastName = "Magana",
            //     height = 182,
            //     jobTitle = "abaaba6",
            //     sex = "M",
            //     weight = 123,
            // };
            // Console.WriteLine("now adding");
            // AdultService.AddAdultAsync(adult1);
            // Console.WriteLine("add succedds!");
          

            
            
            // Console.WriteLine("httpPuting");
            // Console.WriteLine(adult);
            // AdultService.AddAdultAsync(adult);
            // Console.WriteLine("httpPut ok!");
            return Ok();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpGet]
    public IActionResult GetAdults()
    {
        IEnumerable<Adult> adults=  AdultService.GetAdultAsync();
        Console.WriteLine(adults);
         return Ok(adults);
        
    }
    
}
