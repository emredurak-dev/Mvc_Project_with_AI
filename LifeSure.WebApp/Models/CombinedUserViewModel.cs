using LifeSure.WebApp.Models;

namespace LifeSure.WebApp.Models
{
    public class CombinedUserViewModel
    {
        public TwitterUserViewModel TwitterUser { get; set; }
        public LinkedInUserViewModel LinkedInUser { get; set; }
    }
} 