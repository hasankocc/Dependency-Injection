using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalProject
{
    // //uygulamamız içerisinde akışlarımız sırasında loglama ve mesaj gönderme kısımlarının olduğunu düşünelim ve şu şekilde ilgili işlemlerden sorumlu olan sınıflarımız olduğunu varsayalım.
    class Program
    {
        static void Main(string[] args)
        {
            Processor processor = new Processor();
            processor.Process();
            Console.ReadKey();
        }
    }


    class SMSSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(String.Format("SMSSender : {0}", message));
        }
    }
}
