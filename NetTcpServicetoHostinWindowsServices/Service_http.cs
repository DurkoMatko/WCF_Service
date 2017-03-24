using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTcpServicetoHostinWindowsServices
{
   public class Service_http : IService_http
   {
      public string GetData(int value)
      {
         return string.Format("HTTP: You entered: {0}", value);
      }
   }
}
