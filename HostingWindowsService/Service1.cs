using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using NetTcpServicetoHostinWindowsServices;

namespace HostingWindowsService
{
   public partial class Service1 : ServiceBase
   {
      internal static ServiceHost myHost = null;
      BackgroundWorker worker;
      public Service1()
      {
         InitializeComponent();
      }

      protected override void OnStart(string[] args)
      {
         worker = new BackgroundWorker();
         worker.DoWork += new DoWorkEventHandler(worker_DoWork);
      }

      protected override void OnStop()
      {
         if (myHost != null) {
            myHost.Close();
            myHost = null;
         }
      }

      void worker_DoWork(object sender, DoWorkEventArgs e) {
         if (myHost != null)
            myHost.Close();

         myHost = new ServiceHost(typeof(NetTcpServicetoHostinWindowsServices.Service1));
         myHost.Open();
      }
   }
}
