using DesignPatternsApp.Observer.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Observer.Services
{
    public interface IUdemyService
    {
        void CreateCourse(string courseName);
        void AddObserver(ObserverBase observer);
        void RemoveObserver(ObserverBase observer);
    }
}
