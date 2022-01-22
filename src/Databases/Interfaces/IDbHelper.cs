using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Teng.Data.Interfaces
{
    /// <summary>
    /// 遍历状态标志
    /// </summary>
    public enum LoopState
    {
        /// <summary>
        /// 跳出
        /// </summary>
        Break = 0,

        /// <summary>
        /// 继续
        /// </summary>
        Continue
    }

    public interface IDbHelper : IDisposable
    {
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sqls">SQL语句</param>
        void ExecuteQuery(params string[] sqls);

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="loopFunc">回调函数</param>
        /// <param name="paras">参数列表</param>
        /// <returns>行数</returns>
        int ExecuteQuery(string sql, Func<DbDataReader, LoopState> loopFunc, params object[] paras);

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="loopFunc">回调函数</param>
        /// <returns>行数</returns>
        int ExecuteQuery(string sql, Func<DbDataReader, LoopState> loopFunc);

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="loopFunc">回调函数</param>
        /// <param name="parasInitAct">回调函数</param>
        /// <returns>行数</returns>
        int ExecuteQuery(string sql, Func<DbDataReader, LoopState> loopFunc, Action<DbCommand> parasInitAct);

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="paras">参数列表</param>
        /// <returns>行数</returns>
        int ExecuteNonQuery(string sql, params object[] paras);

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sqlAndparas">SQL语句及参数列表</param>
        /// <returns>行数</returns>
        int ExecuteNonQuery(IEnumerable<CommandParametersPair> sqlAndparas);
    }
}