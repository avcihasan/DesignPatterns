using FacadePattern.Services.Abstracts;
using FacadePattern.Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Services
{
    public class AllServicesFacade
    {
        public ILogService LogService;
        public IProductService ProductService;
        public IAuthService AuthService;

        public AllServicesFacade()
        {
            LogService = new LogService();
            ProductService = new ProductService();
            AuthService = new AuthService();
        }
    }
}
