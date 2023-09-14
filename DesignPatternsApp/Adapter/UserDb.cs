using DesignPatternsApp.Adapter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Adapter
{
    public static class UserDb
    {
        public static List<User> Users { get; set; }
        static UserDb()
        {
            Users = new();
        }
    }
}
