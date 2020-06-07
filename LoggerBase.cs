﻿using System;
using System.Collections.Generic;
using System.Text;

namespace commonLogLib
{
    public abstract class LoggerBase2 : ILogger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerBase"/> class.
        /// </summary>
        /// <param name="type">The type to associate with the logger.</param>
        protected LoggerBase2(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerBase"/> class.
        /// </summary>
        /// <param name="name">A custom name to use for the logger.  If null, the type's FullName will be used.</param>
        protected LoggerBase2(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the type associated with the logger.
        /// </summary>
        public Type Type { get; private set; }

        /// <summary>
        /// Gets the name of the logger.
        /// </summary>
        public virtual string Name { get; private set; }

        /// <summary>
        /// Gets a value indicating whether messages with Debug severity should be logged.
        /// </summary>
        public abstract bool IsDebugEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether messages with Info severity should be logged.
        /// </summary>
        public abstract bool IsInfoEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether messages with Trace severity should be logged.
        /// </summary>
        public abstract bool IsTraceEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether messages with Warn severity should be logged.
        /// </summary>
        public abstract bool IsWarnEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether messages with Error severity should be logged.
        /// </summary>
        public abstract bool IsErrorEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether messages with Fatal severity should be logged.
        /// </summary>
        public abstract bool IsFatalEnabled { get; }

        /// <summary>
        /// Logs the specified message with Debug severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public abstract void Debug(string message);

        /// <summary>
        /// Logs the specified message with Debug severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Debug(string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Debug severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Debug(Exception exception, string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Debug severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public abstract void DebugException(string message, Exception exception);

        /// <summary>
        /// Logs the specified message with Info severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public abstract void Info(string message);

        /// <summary>
        /// Logs the specified message with Info severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Info(string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Info severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Info(Exception exception, string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Info severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public abstract void InfoException(string message, Exception exception);

        /// <summary>
        /// Logs the specified message with Trace severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public abstract void Trace(string message);

        /// <summary>
        /// Logs the specified message with Trace severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Trace(string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Trace severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Trace(Exception exception, string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Trace severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public abstract void TraceException(string message, Exception exception);

        /// <summary>
        /// Logs the specified message with Warn severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public abstract void Warn(string message);

        /// <summary>
        /// Logs the specified message with Warn severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Warn(string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Warn severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Warn(Exception exception, string format, params object[] args);

        /// <summary>
        /// Logs the specified message with Warn severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public abstract void WarnException(string message, Exception exception);

        /// <summary>
        /// Logs the specified message with Error severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public abstract void Error(string message);

        /// <summary>
        /// Logs the specified message with Error severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Error(string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Error severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Error(Exception exception, string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Error severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public abstract void ErrorException(string message, Exception exception);

        /// <summary>
        /// Logs the specified message with Fatal severity.
        /// </summary>
        /// <param name="message">The message.</param>
        public abstract void Fatal(string message);

        /// <summary>
        /// Logs the specified message with Fatal severity.
        /// </summary>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Fatal(string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Fatal severity.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="format">The message or format template.</param>
        /// <param name="args">Any arguments required for the format template.</param>
        public abstract void Fatal(Exception exception, string format, params object[] args);

        /// <summary>
        /// Logs the specified exception with Fatal severity.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception to log.</param>
        public abstract void FatalException(string message, Exception exception);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public abstract void SetContextValue(string key, string value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logConfigFile"></param>
        public abstract void ConfigureAndWatch(string logConfigFile);

        public abstract void Configure();
    }
}
