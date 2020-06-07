﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace commonLogLib
{
    public abstract class LoggerFactoryBase : ILoggerFactory
    {
        /// <summary>
        /// The method info for GetCurrentClassLogger
        /// </summary>
        private static readonly MethodInfo GetCurrentClassLoggerMethodInfo =
            typeof(LoggerFactoryBase).GetMethod("GetCurrentClassLogger", BindingFlags.Public | BindingFlags.Instance);

        /// <summary>
        /// Gets the logger for the specified type, creating it if necessary.
        /// </summary>
        /// <param name="type">The type to create the logger for.</param>
        /// <returns>The newly-created logger.</returns>
        public ILogger GetLogger(Type type)
        {
            return this.CreateLogger(type);
        }

        /// <summary>
        /// Gets a custom-named logger for the specified type, creating it if necessary.
        /// </summary>
        /// <param name="name">The explicit name to create the logger for.  If null, the type's FullName will be used.</param>
        /// <returns>The newly-created logger.</returns>
        public ILogger GetLogger(string name)
        {
            return this.CreateLogger(name);
        }

        /// <summary>
        /// Gets the logger for the class calling this method.
        /// </summary>
        /// <returns>The newly-created logger.</returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public ILogger GetCurrentClassLogger()
        {
            var frame = new StackFrame(0, false);
            if (frame.GetMethod() == GetCurrentClassLoggerMethodInfo)
            {
                frame = new StackFrame(1, false);
            }

            var type = frame.GetMethod().DeclaringType;
            if (type == null)
            {
                throw new InvalidOperationException(string.Format("Can not determine current class. Method: {0}", frame.GetMethod()));
            }
            return this.GetLogger(type);
        }

        /// <summary>
        /// Creates a logger for the specified type.
        /// </summary>
        /// <param name="type">The type to create the logger for.</param>
        /// <returns>The newly-created logger.</returns>
        protected abstract ILogger CreateLogger(Type type);

        /// <summary>
        /// Creates a logger with the specified name.
        /// </summary>
        /// <param name="name">The explicit name to create the logger for.  If null, the type's FullName will be used.</param>
        /// <returns>The newly-created logger.</returns>
        protected abstract ILogger CreateLogger(string name);
    }
}
