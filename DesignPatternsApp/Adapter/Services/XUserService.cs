using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Adapter.Services
{
    public class XUserService : IXUserService
    {

        public void XCreateUser(string fullName, int age)
        {
            MessageBox.Show("XUserService Çalıştı...");

            var fullNameSplit = fullName.Split(" ");

            UserDb.Users.Add(new() { Name = fullNameSplit[0], Surname = fullNameSplit[1], Age = age });
        }
    }
}
