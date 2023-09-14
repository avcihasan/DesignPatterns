using DesignPatternsApp.Adapter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Adapter.Services
{
    public interface IUserService
    {
        void CreateUser(string name, string surname,int age);
    }
}
