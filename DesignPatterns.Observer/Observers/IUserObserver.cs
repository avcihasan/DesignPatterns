using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Observer.Observers
{
    public interface IUserObserver
    {
        void CreateUser(AppUser user);
    }
}
