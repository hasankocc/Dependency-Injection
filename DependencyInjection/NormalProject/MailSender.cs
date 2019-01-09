using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalProject
{
    class MailSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(String.Format("MailSender : {0}", message));
        }
    }

    //Case 2 old. durum README dosyasındaki senaryo 2. adıma bakınız.
    //class SMSSender //Ekstra bir class oluşturulur.
    //{
    //    public void SendMessage(string message)
    //    {
    //        Console.WriteLine(String.Format("SMSSender : {0}", message));
    //    }
    //}
}
