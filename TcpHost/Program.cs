using System;
using TcpHost.tcpServiceReference;
using TcpHost.httpServiceReference;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpHost
{
   class Program
   {
      static void Main(string[] args)
      {
         Service1Client proxyTcp = new Service1Client();
         Console.WriteLine(proxyTcp.GetData(2));

         Service_httpClient proxyHttp = new Service_httpClient();
         Console.WriteLine(proxyHttp.GetData(2));

         Console.Read();
      }
   }
}
