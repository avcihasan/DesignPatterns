using DesignPatterns.Template.Models;
using DesignPatterns.Template.UserCards.Abstractions;
using DesignPatterns.Template.UserCards.Concretes;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DesignPatterns.Template.TagHelpers
{
    public class UserCardTagHelper:TagHelper
    {
        public AppUser User { get; set; }

        readonly IHttpContextAccessor _httpContextAccessor;

        public UserCardTagHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            UserCardTemplate userCardTemplate;

            if (!_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
                userCardTemplate = new DefaultUserCardTemplate(User);
            else
                userCardTemplate = new MemberUserCardTemplate(User);


            output.Content.SetHtmlContent(userCardTemplate.Build());
        }

    }
}
