using EasyNetQ;
using RabbitMQ.Message;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.ConsoleSubscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bus = RabbitHutch.CreateBus(ConfigurationManager.AppSettings["CloudamqpURL"]))
            {                
                bus.Subscribe<MessageModel>("g30SqiFhK2HvobX2r8FCVMMUEqXgDD5e", HandleMessage);
                Console.WriteLine("Listening for messages. Hit <return> to quit.");
                Console.ReadLine();
            }
        }

        static void HandleMessage(MessageModel message)
        {
            Console.WriteLine("Message:{0}\r\nUser:{1}\r\nTime{2}\r\n", message.Message, message.UserName, message.SendTime);
        }

    }
}
