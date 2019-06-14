using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olos.OPS.Framework.Logging
{

    public class LogManager
    {
        #region "Attributes"

        private static readonly Olos.OPS.Framework.Core.Interfaces.Log.ILogger _logger = new Log4NetLogger();
        #endregion

        #region "Properties"

        public static Olos.OPS.Framework.Core.Interfaces.Log.ILogger Instance = _logger;

        #endregion

    }
}
