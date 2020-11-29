using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assignment.Models
{
    public class ClientModel
    {
        
        
            public static ClientModel clientModel;
            private ClientModel()
            {}

            public static ClientModel getInstance()
            {
                if (clientModel == null)
                {
                    clientModel = new ClientModel();
                }

                return clientModel;
            }
            public string GetAdultJson()
            {
                Task<string> data = GetDataAsync();
                Console.WriteLine(data);
                string result = data.GetAwaiter().GetResult();
                Console.WriteLine(result);
                return result;
            }
            public void addAdult(Adult adult)
            {
                PostData(adult);
            }

            public string loginAdd(string username,string password)
            {
                try
                {
                    Task<string> data = loginGetData(username,password);
                    Console.WriteLine("loginAdd1");
                    string result = data.GetAwaiter().GetResult();
                    Console.WriteLine(result);
                    return result;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                

            }
            
            static async Task<string> GetDataAsync()
        {
            var httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true
            };
            HttpClient client = new HttpClient(httpClientHandler);
            
            string s = await client.GetStringAsync("https://localhost:5001/Adult");
            return s;
        }
        static async Task<string> PostData(Adult adult)
        {
            var httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true
            };
            HttpClient client = new HttpClient(httpClientHandler);
            string adultSerialized = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(
                adultSerialized,Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage response = await client.PutAsync("https://localhost:5001/Adult", content);
            return response.ToString();
        }
        
        static async Task<string> loginGetData(string username,string password)
        {
            User user = new User
            {
                UserName = username,
                Password = password,
                Role = "Admin",
                
            };
            var httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true
            };
            HttpClient client = new HttpClient(httpClientHandler);
            string userJson = JsonSerializer.Serialize(user);
         
            StringContent content = new StringContent(
                userJson,Encoding.UTF8,
                "application/json"
            );
            string s = await client.GetStringAsync("https://localhost:5001/LoginStatus");
            return s;
            
          
        }
        
        
        
        
        
        
        
        
    }
}