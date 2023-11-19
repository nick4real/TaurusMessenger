using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaurusMessenger.Shared.Model
{
    public class ChatMember
    {
        public int ChatId { get; set; }
        public int UserId { get; set; }
        public bool Admin { get; set; }
    }
}
