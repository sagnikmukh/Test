using System;
using NLog;
using NLog.Config;

namespace commonLogLib.Log4Net
{
    public class NLogLogger : ILogger, IDisposable
    {
        /// <summary>
        /// NLog logger.
        /// </summary>
        private readonly Logger nlogLogger;

        public void Dispose()
        {
            LogManager.Shutdown();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NLogLogger"/> class.
        /// </summary>
        /// <param name="type">The type to create a logger for.</param>
        public NLogLogger(Type type)
        {
            this.nlogLogger = LogManager.GetLogger(type.FullName);
            this.Type = type;
        }

        public Type Type { set; get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NLogLogger"/> class.
        /// </summary>
        /// <param name="name">A custom name to use for the logger.  If null, the type's FullName will be used.</param>
        public NLogLogger(string name)
        {
            this.nlogLogger = LogManager.GetLogger(name);
        }

        /// <summary>
        /// Gets the name of the logger.
        /// </summary>
        /// <value>The name of the logger.</value>
        public string Name
        {
            get
            {
                return this.nlogLogger.Name;
            }
        }

        /// <summary>
        /// Gets a value indicating whether messages with Debug severity should be logged.
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return this.nlogLogger.IsDebugEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether messages with Info severity should be logged.
        /// </summary>
        public  bool IsInfoEnabled
        {
            get { return this.nlogLogger.IsInfoEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether messages with Trace severity should be logged.
        /// </summary>
        public  bool IsTraceEnabled
        {
            get { return this.nlogLogger.IsTraceEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether messages with Warn severity should be logged.
        /// </summary>
        public  bool IsWarnEnabled
        {
            get { return this.nlogLogger.IsWarnEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether messages with Error severity should be logged.
        /// </summary>
        public  bool IsErrorEnabled
        {
            get { return this.nlogLogger.IsErrorEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether messages with Fatal severity should be logged.
        /// </summary>
        public  bool IsFatalEnabled
        {
            get { return this.nlogLogger.IsFatalEnabled; }
        }

        /// <summary>
        /// Logs the specified exception with Debug severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public  void Debug(Exception exception, string format, params object[] args)
        {
            if (this.IsDebugEnabled)
            {
                this.Log(LogLevel.Debug, exception, format, args);
            }
        }

        /// <summary>
        /// Logs the specified exception with Debug severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public  void DebugException(string message, Exception exception)
        {
            if (this.IsDebugEnabled)
            {
                this.nlogLogger.Debug(exception, message);
            }
        }

        /// <summary>
        /// Logs the specified message with Info severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public  void Info(string message)
        {
            if (this.IsInfoEnabled)
            {
                this.Log(LogLevel.Info, "{0}", message);
            }
        }

        /// <summary>
        /// Logs the specified message with Debug severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public  void Debug(string message)
        {
            if (this.IsDebugEnabled)
            {
                this.Log(LogLevel.Debug, "{0}", message);
            }
        }

        /// <summary>
        /// Logs the specified message with Debug severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public  void Debug(string format, params object[] args)
        {
            if (this.IsDebugEnabled)
            {
                this.Log(LogLevel.Debug, format, args);
            }
        }

        /// <summary>
        /// Logs the specified exception with Error severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public  void Error(Exception exception, string format, params object[] args)
        {
            if (this.IsErrorEnabled)
            {
                this.Log(LogLevel.Error, exception, format, args);
            }
        }

        /// <summary>
        /// Logs the specified exception with Error severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public  void ErrorException(string message, Exception exception)
        {
            if (this.IsErrorEnabled)
            {
                this.nlogLogger.Error(exception, message);
            }
        }

        /// <summary>
        /// Logs the specified message with Fatal severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public  void Fatal(string message)
        {
            if (this.IsFatalEnabled)
            {
                this.Log(LogLevel.Fatal, "{0}", message);
            }
        }

        /// <summary>
        /// Logs the specified message with Warn severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public  void WarnException(string message, Exception exception)
        {
            if (this.IsWarnEnabled)
            {
                this.nlogLogger.Warn(exception, message);
            }
        }

        /// <summary>
        /// Logs the specified message with Error severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public  void Error(string message)
        {
            if (this.IsErrorEnabled)
            {
                this.Log(LogLevel.Error, "{0}", message);
            }
        }

        /// <summary>
        /// Logs the specified message with Error severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public  void Error(string format, params object[] args)
        {
            if (this.IsErrorEnabled)
            {
                this.Log(LogLevel.Error, format, args);
            }
        }

        /// <summary>
        /// Logs the specified message with Fatal severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public  void Fatal(string format, params object[] args)
        {
            if (this.IsFatalEnabled)
            {
                this.Log(LogLevel.Fatal, format, args);
            }
        }

        /// <summary>
        /// Logs the specified exception with Fatal severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public  void Fatal(Exception exception, string format, params object[] args)
        {
            if (this.IsFatalEnabled)
            {
                this.Log(LogLevel.Fatal, exception, format, args);
            }
        }

        /// <summary>
        /// Logs the specified exception with Fatal severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public  void FatalException(string message, Exception exception)
        {
            if (this.IsFatalEnabled)
            {
                this.nlogLogger.Fatal(exception, message);
            }
        }

        /// <summary>
        /// Logs the specified message with Info severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public  void Info(string format, params object[] args)
        {
            if (this.IsInfoEnabled)
            {
                this.Log(LogLevel.Info, format, args);
            }
        }

        /// <summary>
        /// Logs the specified exception with Info severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public  void Info(Exception exception, string format, params object[] args)
        {
            if (this.IsInfoEnabled)
            {
                this.Log(LogLevel.Info, exception, format, args);
            }
        }

        /// <summary>
        /// Logs the specified exception with Info severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public  void InfoException(string message, Exception exception)
        {
            if (this.IsInfoEnabled)
            {
                this.nlogLogger.Info(exception, message);
            }
        }

        /// <summary>
        /// Logs the specified message with Trace severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public  void Trace(string message)
        {
            if (this.IsTraceEnabled)
            {
                this.Log(LogLevel.Trace, "{0}", message);
            }
        }

        /// <summary>
        /// Logs the specified message with Trace severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public  void Trace(string format, params object[] args)
        {
            if (this.IsTraceEnabled)
            {
                this.Log(LogLevel.Trace, format, args);
            }
        }

        /// <summary>
        /// Logs the specified exception with Trace severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public  void Trace(Exception exception, string format, params object[] args)
        {
            if (this.IsTraceEnabled)
            {
                this.Log(LogLevel.Trace, exception, format, args);
            }
        }

        /// <summary>
        /// Logs the specified exception with Trace severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public  void TraceException(string message, Exception exception)
        {
            if (this.IsTraceEnabled)
            {
                this.nlogLogger.Trace(exception, message);
            }
        }

        /// <summary>
        /// Logs the specified message with Warn severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public  void Warn(string message)
        {
            if (this.IsWarnEnabled)
            {
                this.Log(LogLevel.Warn, "{0}", message);
            }
        }

        /// <summary>
        /// Logs the specified message with Warn severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public  void Warn(string format, params object[] args)
        {
            if (this.IsWarnEnabled)
            {
                this.Log(LogLevel.Warn, format, args);
            }
        }

        /// <summary>
        /// Logs the specified exception with Warn severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public  void Warn(Exception exception, string format, params object[] args)
        {
            if (this.IsWarnEnabled)
            {
                this.Log(LogLevel.Warn, exception, format, args);
            }
        }

        /// <summary>
        /// Logs with the specified level while preserving the call site.
        /// </summary>
        /// <param name="level">The log level.</param>
        /// <param name="format">The message format.</param>
        /// <param name="args">The argsuments.</param>
        private void Log(LogLevel level, string format, params object[] args)
        {
            var le = new LogEventInfo(level, this.nlogLogger.Name, null, format, args);
            this.nlogLogger.Log(typeof(NLogLogger), le);
        }

        /// <summary>
        /// Logs with the specified level while preserving the call site.
        /// </summary>
        /// <param name="level">The log level.</param>
        /// <param name="exception">The exception.</param>
        /// <param name="format">The message format.</param>
        /// <param name="args">The argsuments.</param>
        private void Log(LogLevel level, Exception exception, string format, params object[] args)
        {
            var le = new LogEventInfo(level, this.nlogLogger.Name, null, format, args, exception);
            this.nlogLogger.Log(typeof(NLogLogger), le);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public  void SetContextValue(string key, string value)
        {            
            MappedDiagnosticsContext.Set(key, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logConfigFile"></param>
        public  void ConfigureAndWatch(string logConfigFile)
        {
            LogManager.Configuration = new XmlLoggingConfiguration(logConfigFile);
        }

        public  void Configure()
        {
            LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        }
    }
}
