﻿using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcems.Logging.Log4Net
{
    public class LoggerService
    {
        private ILog _log;

        public LoggerService(ILog log)
        {
            _log = log;
        }

        public bool IsInfoEnabled => _log.IsInfoEnabled;

        public bool IsDebugEnabled => _log.IsDebugEnabled;

        public bool IsWarnEnabled => _log.IsWarnEnabled;

        public bool IsFatalEnabled => _log.IsFatalEnabled;

        public bool IsErrorEnabled => _log.IsErrorEnabled;

        public void Info(object logMessage)
        {
            if (IsInfoEnabled)
            {
                _log.Info(logMessage);
            }
        }

        public void Debug(object logMessage)
        {
            if (IsInfoEnabled)
            {
                _log.Debug(logMessage);
            }
        }

        public void Warn(object logMessage)
        {
            if (IsInfoEnabled)
            {
                _log.Warn(logMessage);
            }
        }

        public void Fatal(object logMessage)
        {
            if (IsInfoEnabled)
            {
                _log.Fatal(logMessage);
            }
        }

        public void Error(object logMessage)
        {
            if (IsInfoEnabled)
            {
                _log.Error(logMessage);
            }
        }
    }
}
