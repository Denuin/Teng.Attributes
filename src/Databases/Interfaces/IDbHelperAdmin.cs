using System;

namespace Teng.Data.Interfaces
{
    /// <summary>
    /// DbHelper管理
    /// </summary>
    public interface IDbHelperAdmin : IDisposable
    {
        /// <summary>
        /// 检查数据库表
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="tableName">表名（默认为类型名称）</param>
        /// <returns></returns>
        IDbHelperAdmin CheckTable<T>(string tableName = default);

        /// <summary>
        /// 检查数据库表
        /// </summary>
        /// <param name="t">类型</param>
        /// <param name="tableName">表名（默认为类型名称）</param>
        /// <returns></returns>
        IDbHelperAdmin CheckTable(Type t, string tableName = default);

        /// <summary>
        /// 检查数据库表
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <returns></returns>
        IDbHelperAdmin CheckAllTables<T>();

        /// <summary>
        /// 检查数据库表
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        IDbHelperAdmin CheckAllTables(object o);
    }
}