using System;
using Techievibe.Models.Common.Enums;

namespace Techievibe.Models.Entities.Blog
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public AuthEnum Type { get; set; }
        public string DisplayName { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
