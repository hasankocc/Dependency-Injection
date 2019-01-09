using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class SMSSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(String.Format("SMSSender : {0}", message));
        }
    }
}
