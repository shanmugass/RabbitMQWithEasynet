using EasyNetQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Message;
using EasyNetQ.Topology;

namespace RabbitMQ.Publisher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSendMessageClick(object sender, EventArgs e)
        {

            using (var bus = RabbitHutch.CreateBus(ConfigurationManager.AppSettings["CloudamqpURL"]))
            {
                bus.Publish(new MessageModel
                    {
                        Message = txt_MessageToSend.Text,
                        UserName = "Shanmuga",
                        SendTime = DateTime.Now
                    }, "Turniverse");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var bus = RabbitHutch.CreateBus(ConfigurationManager.AppSettings["CloudamqpURL"]))
            {
                var advancedBus = bus.Advanced;

                var exchange = advancedBus.ExchangeDeclare("my_exchange", ExchangeType.Fanout);

                var messageToSend = new MessageModel
                {
                    Message = txt_MessageToSend.Text,
                    UserName = "Shanmuga",
                    SendTime = DateTime.Now
                };

                bus.Advanced.Publish(exchange, "TestQueue", false, false, new Message<MessageModel>(messageToSend));

            }
        }
    }
}
