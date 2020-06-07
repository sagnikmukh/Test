using log4net;
using log4net.Config;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace commonLogLib.Log4Net
{
    public class Log4NetLogger : ILogger
    {
        /// <summary>
        /// The logger used by this instance.
        /// </summary>
        private readonly ILog log4NetLogger;
        //private Type Type;

        /// <summary>
        /// Initializes a new instance of the <see cref="Log4NetLogger"/> class.
        /// </summary>
        /// <param name="type">The type to create a logger for.</param>
        public Log4NetLogger(Type type)
        {
            this.log4NetLogger = LogManager.GetLogger(type);
            this.Type = type;
        }

        public Type Type {set;get;}

        /// <summary>
        /// Initializes a new instance of the <see cref="Log4NetLogger"/> class.
        /// </summary>
        /// <param name="name">A custom name to use for the logger.  If null, the type's FullName will be used.</param>
        public Log4NetLogger(string name)           
        {
            this.log4NetLogger = LogManager.GetLogger(Assembly.GetCallingAssembly(), name);
        }

        /// <summary>
        /// Gets the name of the logger.
        /// </summary>
        /// <value>The name of the logger.</value>
        public string Name
        {
            get { return this.log4NetLogger.Logger.Name; }
        }

        /// <summary>
        /// Gets a value indicating whether messages with Debug severity should be logged.
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return this.log4NetLogger.IsDebugEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether messages with Info severity should be logged.
        /// </summary>
        public bool IsInfoEnabled
        {
            get { return this.log4NetLogger.IsInfoEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether messages with Trace severity should be logged.
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return this.log4NetLogger.Logger.IsEnabledFor(Level.Trace); }
        }

        /// <summary>
        /// Gets a value indicating whether messages with Warn severity should be logged.
        /// </summary>
        public bool IsWarnEnabled
        {
            get { return this.log4NetLogger.IsWarnEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether messages with Error severity should be logged.
        /// </summary>
        public bool IsErrorEnabled
        {
            get { return this.log4NetLogger.IsErrorEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether messages with Fatal severity should be logged.
        /// </summary>
        public bool IsFatalEnabled
        {
            get { return this.log4NetLogger.IsFatalEnabled; }
        }

        /// <summary>
        /// Logs the specified message with Debug severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Debug(string message)
        {
            this.Log(Level.Debug, message, null);
        }

        /// <summary>
        /// Logs the specified message with Debug severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public void Debug(string format, params object[] args)
        {
            this.Log(Level.Debug, format, null, args);
        }

        /// <summary>
        /// Logs the specified exception with Debug severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public void Debug(Exception exception, string format, params object[] args)
        {
            this.Log(Level.Debug, format, exception, args);
        }

        /// <summary>
        /// Logs the specified exception with Debug severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public void DebugException(string message, Exception exception)
        {
            this.Log(Level.Debug, message, exception);
        }

        /// <summary>
        /// Logs the specified message with Info severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Info(string message)
        {
            this.Log(Level.Info, message, null);
        }

        /// <summary>
        /// Logs the specified message with Info severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public void Info(string format, params object[] args)
        {
            this.Log(Level.Info, format, null, args);
        }

        /// <summary>
        /// Logs the specified exception with Info severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public void Info(Exception exception, string format, params object[] args)
        {
            this.Log(Level.Info, format, exception, args);
        }

        /// <summary>
        /// Logs the specified exception with Info severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public void InfoException(string message, Exception exception)
        {
            this.Log(Level.Info, message, exception);
        }

        /// <summary>
        /// Logs the specified message with Trace severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Trace(string message)
        {
            this.Log(Level.Trace, message, null);
        }

        /// <summary>
        /// Logs the specified message with Trace severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public void Trace(string format, params object[] args)
        {
            this.Log(Level.Trace, format, null, args);
        }

        /// <summary>
        /// Logs the specified exception with Trace severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public void Trace(Exception exception, string format, params object[] args)
        {
            this.Log(Level.Trace, format, exception, args);
        }

        /// <summary>
        /// Logs the specified exception with Trace severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public void TraceException(string message, Exception exception)
        {
            this.Log(Level.Trace, message, exception);
        }

        /// <summary>
        /// Logs the specified message with Warn severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Warn(string message)
        {
            this.Log(Level.Warn, message, null);
        }

        /// <summary>
        /// Logs the specified message with Warn severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public void Warn(string format, params object[] args)
        {
            this.Log(Level.Warn, format, null, args);
        }

        /// <summary>
        /// Logs the specified exception with Warn severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public void Warn(Exception exception, string format, params object[] args)
        {
            this.Log(Level.Warn, format, exception, args);
        }

        /// <summary>
        /// Logs the specified message with Warn severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public void WarnException(string message, Exception exception)
        {
            this.Log(Level.Warn, message, exception);
        }

        /// <summary>
        /// Logs the specified message with Error severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Error(string message)
        {
            this.Log(Level.Error, message, null);
        }

        /// <summary>
        /// Logs the specified message with Error severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public void Error(string format, params object[] args)
        {
            this.Log(Level.Error, format, null, args);
        }

        /// <summary>
        /// Logs the specified exception with Error severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public void Error(Exception exception, string format, params object[] args)
        {
            this.Log(Level.Error, format, exception, args);
        }

        /// <summary>
        /// Logs the specified exception with Error severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public void ErrorException(string message, Exception exception)
        {
            this.Log(Level.Error, message, exception);
        }

        /// <summary>
        /// Logs the specified message with Fatal severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Fatal(string message)
        {
            this.Log(Level.Fatal, message, null);
        }

        /// <summary>
        /// Logs the specified message with Fatal severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public void Fatal(string format, params object[] args)
        {
            this.Log(Level.Fatal, format, null, args);
        }

        /// <summary>
        /// Logs the specified exception with Fatal severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public void Fatal(Exception exception, string format, params object[] args)
        {
            this.Log(Level.Fatal, format, exception, args);
        }

        /// <summary>
        /// Logs the specified exception with Fatal severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public void FatalException(string message, Exception exception)
        {
            this.Log(Level.Fatal, message, exception);
        }

        /// <summary>
        /// Calls the actual log4netlogger using the preferred wrapped method.
        /// </summary>
        /// <param name="level">The level to log at.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        private void Log(Level level, string format, Exception exception, params object[] args)
        {
            if (this.log4NetLogger.Logger.IsEnabledFor(level))
            {
                if (args != null && args.Length > 0)
                {
                    this.log4NetLogger.Logger.Log(this.Type, level, string.Format(format, args), exception);
                }
                else
                {
                    this.log4NetLogger.Logger.Log(this.Type, level, format, exception);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void SetContextValue(string key, string value)
        {
            MDC.Set(key, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logConfigFile"></param>
        public void ConfigureAndWatch(string logConfigFile)
        {
            XmlConfigurator.ConfigureAndWatch(LogManager.GetRepository(Assembly.GetCallingAssembly()),new FileInfo(logConfigFile));
        }

        public void Configure()
        {
            XmlConfigurator.Configure(LogManager.GetRepository(Assembly.GetCallingAssembly()));            
        }
    }
}
