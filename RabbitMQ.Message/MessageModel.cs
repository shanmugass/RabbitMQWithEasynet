using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Message
{
    public class MessageModel
    {
        public string Message { get; set; }
        public string UserName { get; set; }
        public DateTime SendTime { get; set; }
    }
}
