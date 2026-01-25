using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
    internal class Program
    {
        private static readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("http://localhost:8080")
        };
        static async Task Main(string[] args)
        {
            List<UserDto> users = await _httpClient.GetFromJsonAsync<List<UserDto>>("/api/users");
            if (users is null)
            {
                Console.WriteLine("null");
            }

            foreach (var user in users)
            {
                Console.WriteLine(user.Username);
            }
        }
    }
}
