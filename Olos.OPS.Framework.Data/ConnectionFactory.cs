using Olos.OPS.Framework.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olos.OPS.Framework.Data
{
    public static class ConnectionFactory
    {
        #region "Constants"

        private const string DefaultConnectionAppSettingName = "Application.DefaultConnectionName";

        #endregion

        public static IDbConnection GetConnection(string connectionString)
        {
            try
            {
                if (connectionString == "")
                {
                    throw new InvalidOperationException($"Connection String '{connectionString}' not found.");
                }

                SqlConnection connection = new SqlConnection(connectionString);

                if (connection == null)
                {
                    throw new InvalidOperationException("Connection cannot be created by Provider");
                }
                connection.Open();

                return connection;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

