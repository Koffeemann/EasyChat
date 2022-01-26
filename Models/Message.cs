using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChat.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Author{ get; set; }
        public string Text { get; set; }
    }
}
