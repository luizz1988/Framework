using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olos.OPS.Framework.Core.Interfaces.Data
{
    public interface IConnectionHelper
    {
        void Use(string connectionString, Action<IDbConnection> action);
        object Use(string connectionString, Func<IDbConnection, object> p);
        TResult Use<TResult>(string connectionString, Func<IDbConnection, TResult> func);

        Task UseAsync(string connectionString, Action<IDbConnection> action);

        Task<TResult> UseAsync<TResult>(string connectionString, Func<IDbConnection, TResult> func);

        void UseWithTransaction(string connectionString, Action<IDbConnection, IDbTransaction> action);

        void UseWithTransaction(string connectionString, Action<IDbConnection> action);

        Task UseWithTransactionAsync(string connectionString, Action<IDbConnection, IDbTransaction> action);

        Task UseWithTransactionAsync(string connectionString, Action<IDbConnection> action);
    }
}
