using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalProject
{
    class Processor
    {
        public void Process()
        {
            DBLogger logger = new DBLogger();
            logger.WriteLog("Log Text");
            //Ana Uygulama Akışı          
            MailSender messageSender = new MailSender();
            messageSender.SendMessage("Message Text");
        }
    }

    //Case 2 old. durum README dosyasındaki senaryo 2. adıma bakınız.
   //class Processor //Processor da değişiklik yapılır.Güvenli bir yol değil ayrıca SOLID Open/Close prensibine aykırı.
   //{
   //    public void Process()
   //    {
   //        //DBLogger logger = new DBLogger();                   
   //        FileLogger logger = new FileLogger();
   //        logger.WriteLog("Log Text");
   //        //Ana Uygulama Akışı          
   //        //MailSender messageSender = new MailSender();
   //        SMSSender messageSender = new SMSSender();
   //        messageSender.SendMessage("Message Text");
   //    }
   //}
}
