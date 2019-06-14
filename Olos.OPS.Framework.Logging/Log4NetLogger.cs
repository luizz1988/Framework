using log4net;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Repository;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

namespace Olos.OPS.Framework.Logging
{
    internal sealed class Log4NetLogger : Olos.OPS.Framework.Core.Interfaces.Log.ILogger
    {
        private ILog _log = log4net.LogManager.GetLogger(typeof(Log4NetLogger));

        public void Debug(string message)
        {
            
            if (_log.IsDebugEnabled)
            {
                _log.Debug(message);
            }
        }
      
        public void Info(string message)
        {
            if (_log.IsInfoEnabled)
            {
                _log.Info(message);
            }
        }

        public void Warning(string message)
        {
            if (_log.IsWarnEnabled)
            {
                _log.Warn(message);

            }
        }

        public void Error(string message)
        {
            if (_log.IsErrorEnabled)
            {
                _log.Error(message);
            }
        }

        public void Error(string message, Exception ex)
        {
            if (_log.IsErrorEnabled)
            {
                _log.Error(message, ex);
            }
        }

        public void Error(string message, Exception ex, object obj)
        {
            if (_log.IsErrorEnabled)
            {
                _log.Error(message, ex);
            }
        }

        public void Close()
        {

            _log = null;
        }

    }
}
