using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalProject
{
    class DBLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(String.Format("DBLogger : {0}", message));
        }
    }

    // Case 2 old. durum README dosyasındaki senaryo 2. adıma bakınız.
    // class FileLogger  //Ekstra bir class oluşturulur.
    // {
    //     public void WriteLog(string message)
    //     {
    //         Console.WriteLine(String.Format("FileLogger : {0}", message));
    //     }
    // }
}
