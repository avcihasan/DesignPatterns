using DesignPatterns.Template.Models;
using System.Text;

namespace DesignPatterns.Template.UserCards.Abstractions
{
    public abstract class UserCardTemplate
    {
        protected AppUser User { get; }
        public UserCardTemplate(AppUser User)
        {
            this.User = User;
        }
        public string Build()
        {
            if (User is null) throw new ArgumentNullException();
            StringBuilder stringBuilder = new();
            stringBuilder.Append("<div class='card'>");
            stringBuilder.Append(SetPicture());
            stringBuilder.Append($@"<div class='card-body'
                                        <h5>{User.UserName}</h5>
                                         <p>{User.Description}</p>");
            stringBuilder.Append(SetFooter());
            stringBuilder.Append("</div>");
            stringBuilder.Append("</div>");

            return stringBuilder.ToString();
        }

        public abstract string SetFooter();
        public abstract string SetPicture();

    }
}
