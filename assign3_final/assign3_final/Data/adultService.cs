using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using assign3_final.DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;

namespace assign3_final.Data
{
    public class adultService : IAdultService
    {
        private string adultFile = "adult.json";
        private aDBContext dbcontext;
        private IList<Adult> adults;

        public adultService()
        {
            string content = File.ReadAllText(adultFile);
            adults = JsonSerializer.Deserialize<List<Adult>>(content);
            dbcontext = new aDBContext();
            
            
        }

        private async Task WriteToFile()
        {
            string productsAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(adultFile, productsAsJson);
        }

        public async Task AddAdultAsync(Adult adult)
        {
            Console.WriteLine("addAdulting 1!");
            adults.Add(adult);
            Console.WriteLine("addAdulting 2!");
            await dbcontext.Adult.AddAsync(adult);
            Console.WriteLine("addAdulting 3!");
            try
            {
                await dbcontext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            Console.WriteLine("addAdulting 4!");
            WriteToFile();
            Console.WriteLine("addADULT succedds!");
        }


        public IEnumerable<Adult> GetAdultAsync()
        {
            return dbcontext.Adult;
        }

     

        // public IEnumerable<Adult> GetAdultsBySearch()
        // {
        //     
        //     
        //     
        // }


        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }
    }
}