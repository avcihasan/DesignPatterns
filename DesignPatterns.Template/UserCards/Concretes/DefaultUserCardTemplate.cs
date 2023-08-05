using DesignPatterns.Template.Models;
using DesignPatterns.Template.UserCards.Abstractions;

namespace DesignPatterns.Template.UserCards.Concretes
{
    public class DefaultUserCardTemplate : UserCardTemplate
    {
        public DefaultUserCardTemplate(AppUser User) : base(User)
        {
        }

        public override string SetFooter()
            => string.Empty;

        public override string SetPicture()
            => "<img class='card-img-top' src='/img/default.jpg' >";
    }
}
