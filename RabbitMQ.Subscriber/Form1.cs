using EasyNetQ;
using RabbitMQ.Message;
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

namespace RabbitMQ.Subscriber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadRabbitMQ();
        }

        private void LoadRabbitMQ()
        {
          
        }

        static void HandleMessage(MessageModel message)
        {
            MessageBox.Show(string.Format("Message:{0}\r\nUser:{1}\r\nTime{2}\r\n", message.Message, message.UserName, message.SendTime));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var bus = RabbitHutch.CreateBus(ConfigurationManager.AppSettings["CloudamqpURL"]))
            {
                bus.Subscribe<MessageModel>("g30SqiFhK2HvobX2r8FCVMMUEqXgDD5e", HandleMessage);
            }
        }
    }
}
