using DesignPatternsApp.Observer.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Observer.Services
{
    public class UdemyService: IUdemyService
    {
        List<ObserverBase> _observers;
        public UdemyService()
        {
            _observers = new();
        }
        public void CreateCourse(string courseName)
        {
            Notify();
        }



        public void AddObserver(ObserverBase observer)
            => _observers.Add(observer);
        public void RemoveObserver(ObserverBase observer)
            => _observers.Remove(observer);
        private void Notify()
        {
            foreach (var observer in _observers)
                observer.Update();
        }
        



    }
}
