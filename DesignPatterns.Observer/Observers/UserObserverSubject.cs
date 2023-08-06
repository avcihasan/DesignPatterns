using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Observer.Observers
{
    public class UserObserverSubject
    {
        readonly List<IUserObserver> _observers;

        public UserObserverSubject()
        {
            _observers = new();
        }

        public void AddObserver(IUserObserver userObserver)
            => _observers.Add(userObserver);
        public void RemoveObserver(IUserObserver userObserver)
            => _observers.Remove(userObserver);
        public void NotifyObserver(AppUser user)
            => _observers.ForEach(x => x.CreateUser(user));
    }
}
