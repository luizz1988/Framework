using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Olos.OPS.Framework.Teste
{
    class Program
    {
        private static string SQLServerName = string.Empty;
        private static string SQLDataBaseName = string.Empty;
        private static string SQLUserName = string.Empty;
        private static string SQLPassword = string.Empty;

        static void Main(string[] args)
        {
            Olos.OPS.Framework.Logging.LogManager.Instance.Info("Log de Info");
            Olos.OPS.Framework.Logging.LogManager.Instance.Error("Log de Error");
            Olos.OPS.Framework.Logging.LogManager.Instance.Debug("Log de Debg");
            Olos.OPS.Framework.Logging.LogManager.Instance.Warning("Log Warning");


            SQLUserName = Olos.OPS.Framework.Crypt.EncryptManager.Instance.Decrypt("UTjjkEyNAlQ=");
            SQLPassword = Olos.OPS.Framework.Crypt.EncryptManager.Instance.Decrypt("cmgvS1zXu/6aSsvXYzsmtA==");
            SQLServerName = Olos.OPS.Framework.Crypt.EncryptManager.Instance.Decrypt("jMSz8/1BJwriWp0UWXVpVw==");
            String connectionString = string.Format("Data Source={0}; Initial Catalog=Sysconfiguration; User Id={2}; Password={3}", SQLServerName, SQLDataBaseName, SQLUserName, SQLPassword);

            try
            {

                string query = @"SELECT TOP (1000) [EventTypeId] as EventTypeId ,[Description] as Description  FROM [CampaignControl].[dbo].[INFO_EventType] where EventTypeId = @EventTypeId";

                var result = Olos.OPS.Framework.Data.ConnectionHelper.Instance.Use(connectionString, conn =>
                 {
                     var parameters = new { EventTypeId = 10 };

                     return conn.Query<ReturnTeste>(query, parameters);
                 });

               
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
