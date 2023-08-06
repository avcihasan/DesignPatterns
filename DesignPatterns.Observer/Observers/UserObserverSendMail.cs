using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Observer.Observers
{
    public class UserObserverSendMail : IUserObserver
    {
        readonly IServiceProvider _serviceProvider;

        public UserObserverSendMail(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateUser(AppUser user)
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<UserObserverSendMail>>();
            logger.LogInformation("send mail ");
        }
    }
}
