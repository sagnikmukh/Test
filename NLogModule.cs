using System;
using System.Collections.Generic;
using System.Text;

namespace commonLogLib.Log4Net
{
    public static class NLogModule 
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public static ILogger Load(Type type)
        {
            ILoggerFactory loggerFactory = new NLogLoggerFactory();
            return (ILogger)loggerFactory.GetLogger(type);
        }
    }
}
