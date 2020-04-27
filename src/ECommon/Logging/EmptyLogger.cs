﻿using System;

namespace ECommon.Logging
{
    /// <summary>An empty logger which log nothing.
    /// </summary>
    public class EmptyLogger : ILogger
    {
        public bool IsDebugEnabled
        {
            get
            {
                return false;
            }
        }

        public void Debug(string message)
        {
        }

        public void Debug(string message, Exception exception)
        {
        }

        public void DebugFormat(string format, params object[] args)
        {
        }

        public void Error(string message)
        {
        }

        public void Error(string message, Exception exception)
        {
        }

        public void ErrorFormat(string format, params object[] args)
        {
        }

        public void Fatal(string message)
        {
        }

        public void Fatal(string message, Exception exception)
        {
        }

        public void FatalFormat(string format, params object[] args)
        {
        }

        public void Info(string message)
        {
        }

        public void Info(string message, Exception exception)
        {
        }

        public void InfoFormat(string format, params object[] args)
        {
        }

        public void Warn(string message)
        {
        }

        public void Warn(string message, Exception exception)
        {
        }

        public void WarnFormat(string format, params object[] args)
        {
        }
    }
}