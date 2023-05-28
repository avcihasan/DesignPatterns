using FacadePattern.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Services.Concretes
{
    public class AuthService : IAuthService
    {
        public void SignIn()
        {
            Console.WriteLine("SignIn");
        }
    }
}
