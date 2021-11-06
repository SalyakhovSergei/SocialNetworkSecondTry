using SocialNetworkSecondTry.Models.Users;

namespace SocialNetworkSecondTry.ViewModels
{
    public class UserWithFriendExt : User
    {
        public bool IsFriendWithCurrent { get; set; }
    }
}