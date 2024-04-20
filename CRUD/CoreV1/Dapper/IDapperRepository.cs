using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1.Dapper
{
    public interface IDapperRepository : IDisposable
    {
        DbConnection GetDbconnection(string connectionName);
        T Get<T>(string sp, DynamicParameters parms, string connectionName, CommandType commandType = CommandType.StoredProcedure);
        List<T> GetAll<T>(string sp, DynamicParameters parms, string connectionName, CommandType commandType = CommandType.StoredProcedure);
        int Execute(string sp, DynamicParameters parms, string connectionName, CommandType commandType = CommandType.StoredProcedure);
        T Insert<T>(string sp, DynamicParameters parms, string connectionName, CommandType commandType = CommandType.StoredProcedure);
        T Update<T>(string sp, DynamicParameters parms, string connectionName, CommandType commandType = CommandType.StoredProcedure);
    }
}
