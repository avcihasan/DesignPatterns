using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Adapter.Services
{
    public interface  IXUserService
    {
        void XCreateUser(string fullName, int age);
    }
}
