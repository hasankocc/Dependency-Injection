using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    interface IMessageSender
    {
        void SendMessage(string Message);
    }
    interface ILogger
    {
        void WriteLog(string message);
    }
}
