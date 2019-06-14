using Olos.OPS.Framework.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olos.OPS.Framework.Data
{
    public class ConnectionHelper : IConnectionHelper
    {
        #region "Constants"

        public const int Timeout = 1800;

        #endregion

        #region "Constructor"

        private ConnectionHelper()
        {

        }

        #endregion

        #region "Properties"

        public static IConnectionHelper Instance => new ConnectionHelper();

        #endregion

        #region "Methods"

        public TResult Use<TResult>(string connectionString, Func<IDbConnection, TResult> func)
        {
            TResult result;

            using (var conn = ConnectionFactory.GetConnection(connectionString))
            {
                result = func(conn);
            }

            return result;
        }

        public Task<TResult> UseAsync<TResult>(string connectionString, Func<IDbConnection, TResult> func)
        {
            return Task.Factory.StartNew(() => Use(connectionString, func));
        }

        public void Use(string connectionString, Action<IDbConnection> action)
        {
            using (var conn = ConnectionFactory.GetConnection(connectionString))
            {
                action(conn);
            }
        }

        public Task UseAsync(string connectionString, Action<IDbConnection> action)
        {
            return Task.Factory.StartNew(() => Use(connectionString, action));
        }

        public void UseWithTransaction(string connectionString, Action<IDbConnection, IDbTransaction> action)
        {
            using (var conn = ConnectionFactory.GetConnection(connectionString))
            {
                using (var transaction = conn.BeginTransaction())
                {
                    action(conn, transaction);

                    transaction.Commit();
                }
            }
        }

        public void UseWithTransaction(string connectionString, Action<IDbConnection> action)
        {
            using (var conn = ConnectionFactory.GetConnection(connectionString))
            {
                using (var transaction = conn.BeginTransaction())
                {
                    action(conn);

                    transaction.Commit();
                }
            }
        }

        public Task UseWithTransactionAsync(string connectionString, Action<IDbConnection, IDbTransaction> action)
        {
            return Task.Factory.StartNew(() => UseWithTransaction(connectionString, action));
        }

        public Task UseWithTransactionAsync(string connectionString, Action<IDbConnection> action)
        {
            return Task.Factory.StartNew(() => UseWithTransaction(connectionString, action));
        }

        public object Use(string connectionString, Func<IDbConnection, object> p)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
