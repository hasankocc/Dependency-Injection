using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Processor
    {
        ILogger logger = null;
        IMessageSender messageSender;
        public Processor(ILogger _logger, IMessageSender _messageSender)
        {
            logger = _logger;
            messageSender = _messageSender;
        }
        public void Process()
        {
            logger.WriteLog("Log Text");
            //Ana Uygulama Akışı                    
            messageSender.SendMessage("Message Text");
        }
    }
}
