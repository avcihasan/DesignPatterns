using DesignPatterns.Strategy.Models;

namespace DesignPatterns.Observer.Observers
{
    public class UserObserverCreateDiscount : IUserObserver
    {

        readonly IServiceProvider  _serviceProvider;

        public UserObserverCreateDiscount(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateUser(AppUser user)
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<UserObserverCreateDiscount>>();
            var scope = _serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            context.Discounts.Add(new() { Rate = 15, UserId = user.Id });
            context.SaveChanges();
            logger.LogInformation("created discount");
        }
    }
}
