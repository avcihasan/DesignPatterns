using DesignPatternsApp.Singleton.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Singleton.Services
{
    public class GetCityService
    {
        private static List<City> _instance;
        public static List<City> Instance => _instance;
        static GetCityService()
        {
            MessageBox.Show("GetCityService Nesnesi Oluştu");
            _instance = new()
            {
                new(){Name="Ankara"},
                new(){Name="İstanbul"},
                new(){Name="Çanakkale"},
            };
           

        }
        private GetCityService()
        {

        }
    }
}
