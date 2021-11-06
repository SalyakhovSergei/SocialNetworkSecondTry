using System.Collections.Generic;
using SocialNetworkSecondTry.Models.Users;

namespace SocialNetworkSecondTry.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }

        public UserViewModel(User user)
        {
            User = user;
        }

        public List<User> Friends { get; set; }

    }
}