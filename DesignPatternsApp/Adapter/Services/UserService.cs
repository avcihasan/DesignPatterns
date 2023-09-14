using DesignPatternsApp.Adapter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Adapter.Services
{
    public class UserService : IUserService
    {
        public void CreateUser(string name, string surname, int age)
        {
            UserDb.Users.Add(new() { Age=age,Name=name,Surname=surname});
        }
    }
}
