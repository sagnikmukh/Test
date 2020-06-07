
using commonLogLib;
using commonLogLib.Log4Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        protected internal static ILogger logger = null;

        static void Main(string[] args)
        {
            //logger = Log4NetModule.Load(MethodBase.GetCurrentMethod().DeclaringType);
            //logger.SetContextValue("App", "RM");
            ////logger.Configure();
            //logger.ConfigureAndWatch("log4net.config");

            logger = NLogModule.Load(MethodBase.GetCurrentMethod().DeclaringType);
            logger.SetContextValue("App", "RM");
            logger.ConfigureAndWatch("Config\NLog.config");

            //logger.Info("nlog 5");

            test tst = new test(logger);
            tst.testing();

            Console.WriteLine("Hello World!");
        }
    }

    public class test
    {
        ILogger _logger = null;
        public test(ILogger logger)
        {
            _logger = logger;
        }

        public void testing()
        {
            _logger.Info("from testing");
        }
    }
}
