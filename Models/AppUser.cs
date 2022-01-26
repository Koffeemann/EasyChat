using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChat.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string password { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

    }
}
