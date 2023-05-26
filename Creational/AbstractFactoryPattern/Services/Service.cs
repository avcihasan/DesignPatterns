using AbstractFactoryPattern.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Services
{
    public class Service : IService
    {
        AbstractCreator _abstractCreator;

        public Service(AbstractCreator abstractCreator)
        {
            _abstractCreator = abstractCreator;
        }

        public void GetAll()
        {
            Console.WriteLine("GetAll Metodu Çalıştı");
           _abstractCreator.CacheCreate().Cache("GetAll");
            _abstractCreator.LogCreate().Log("GetAll");
        }
    }
}
