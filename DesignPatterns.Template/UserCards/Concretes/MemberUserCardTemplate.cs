using DesignPatterns.Template.Models;
using DesignPatterns.Template.UserCards.Abstractions;
using System.Text;

namespace DesignPatterns.Template.UserCards.Concretes
{
    public class MemberUserCardTemplate : UserCardTemplate
    {
        public MemberUserCardTemplate(AppUser User) : base(User)
        {
        }

        public override string SetFooter()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.Append($"<a href='#' class='card-link' >Mesaj Gönder</a>");
            stringBuilder.Append($"<a href='#' class='card-link' >Profil</a>");
            return stringBuilder.ToString();
        }

        public override string SetPicture()
            => $"<img class='card-img-top' src='{User.Picture}' >";
    }
}
