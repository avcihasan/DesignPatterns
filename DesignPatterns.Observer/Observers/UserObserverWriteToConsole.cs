using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Observer.Observers
{
    public class UserObserverWriteToConsole : IUserObserver
    {
        readonly IServiceProvider _serviceProvider;

        public UserObserverWriteToConsole(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateUser(AppUser user)
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<UserObserverWriteToConsole>>();
            logger.LogInformation($"user created {user.UserName}");
        }
    }
}
