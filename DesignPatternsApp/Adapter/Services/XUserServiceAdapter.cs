using DesignPatternsApp.Adapter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Adapter.Services
{
    public class XUserServiceAdapter : IUserService
    {

        readonly IXUserService _xUserService;
        public XUserServiceAdapter()
        {
            _xUserService = new XUserService();
        }

        public List<User> Users { get; private set; }

        public void CreateUser(string name, string surname, int age)
        {
            _xUserService.XCreateUser($"{name} {surname}",age);
        }
    }
}
