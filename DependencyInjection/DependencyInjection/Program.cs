using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DependencyInjection
{
    //uygulamamız içerisinde akışlarımız sırasında loglama ve mesaj gönderme kısımlarının olduğunu düşünelim ve şu şekilde ilgili işlemlerden sorumlu olan sınıflarımız olduğunu varsayalım.
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Processor processor = new Processor(CreateLogger(), CreateMessageSender());
                processor.Process();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message);
            }
            Console.ReadKey();
        }

        static IMessageSender CreateMessageSender()
        {
            IMessageSender retVal=null;
            string messageSender = ConfigurationManager.AppSettings["messageSMS"].ToString();
            switch (messageSender)
            {
                case "SMS":
                    retVal = new SMSSender();
                    break;
                case "Mail":
                    retVal = new MailSender();
                    break;
            }
            return retVal;
        }
        static ILogger CreateLogger()
        {
            ILogger retVal=null;
            string logger = ConfigurationManager.AppSettings["loggerFile"].ToString();
            switch (logger)
            {
                case "DB":
                    retVal = new DBLogger();
                    break;
                case "File":
                    retVal = new FileLogger();
                    break;
            }
            return retVal;
        }
    }
}
