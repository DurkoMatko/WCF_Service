using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTcpServicetoHostinWindowsServices
{
   public class Service1:IService1
   {
      public string GetData(int value) {
         return string.Format("TCP: You entered: {0}", value);
      }
   }
}
