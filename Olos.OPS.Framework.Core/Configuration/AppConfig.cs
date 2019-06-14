using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olos.OPS.Framework.Core.Configuration
{
    public static class AppConfig
    {
        #region "Properties"

        public static IConfiguration Configuration { get; set; }

        #endregion

        #region "Methods"

        /// <summary>
        /// Get Application Setting by name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public static T GetValue<T>(string name)
        {
            CheckIfConfigurationIsSet();

            var value = Configuration[name];

            return (T)Convert.ChangeType(value, typeof(T));
        }

        private static void CheckIfConfigurationIsSet()
        {
            if (Configuration == null)
            {
                throw new InvalidOperationException("Configuration must be set in application startup.");
            }
        }

        #endregion
    }
}
