using System;

namespace Teng.Data.Interfaces
{
    public interface IDbHelperAdmin : IDisposable
    {
        IDbHelperAdmin CheckTable<T>(string tableName = default);

        IDbHelperAdmin CheckTable(Type t, string tableName = default);

        IDbHelperAdmin CheckAllTables<T>();

        IDbHelperAdmin CheckAllTables(object o);
    }
}