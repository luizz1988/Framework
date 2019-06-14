using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olos.OPS.Framework.WayApiLog
{
    internal sealed  class WayApiLog
    {

        public bool InsertApiLog(UInt64 callId, string basicUrl, string requestHeaders, string request, string response, int totalTime, string connectionString)
        {
            try
            {
                string query = @"INSERT INTO [WayLogDB].[dbo].[APILog] ([Id],[CallId],[CampaignId],[BasicURL],[RequestHeaders],[Request],[Response],[TotalTime],[InsertDate]) VALUES (@Id,@CallId,@Camp,@Basic,@ReqHeaders,@Request,@Response,@TotalTime,@InserDate)";
                var result = Olos.OPS.Framework.Data.ConnectionHelper.Instance.Use(connectionString, conn =>
                {
                    var param = new { };

                    return conn.Query(query);
                });

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
