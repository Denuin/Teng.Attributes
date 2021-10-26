using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Teng.Data.Interfaces
{
    public enum LoopState
    {
        Break = 0,
        Continue
    }

    public interface IDbHelper : IDisposable
    {
        void ExecuteNonQuery(params string[] sqls);

        int ExecuteNonQuery(string sql, params object[] paras);

        int ExecuteQuery(string sql, Func<DbDataReader, LoopState> loopFunc, params object[] paras);

        int ExecuteQuery(string sql, Func<DbDataReader, LoopState> loopFunc);

        int ExecuteQuery(string sql, Func<DbDataReader, LoopState> loopFunc, Action<DbCommand> parasInitAct);

        int ExecuteNonQuery(IEnumerable<CommandParametersPair> sqlAndparas);
    }
}