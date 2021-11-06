using System.Collections.Generic;
using SocialNetworkSecondTry.Models.Users;

namespace SocialNetworkSecondTry.ViewModels
{
    public class ChatViewModel
    {
        public User You { get; set; }

        public User ToWhom { get; set; }

        public List<Message> History { get; set; }

        public MessageViewModel NewMessage { get; set; }

        public ChatViewModel()
        {
            NewMessage = new MessageViewModel();
        }
    }
}