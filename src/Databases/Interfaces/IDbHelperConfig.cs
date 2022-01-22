namespace Teng.Data.Interfaces
{
    /// <summary>
    /// DbHelper配置
    /// </summary>
    public interface IDbHelperConfig
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        string ConnectionString { get; }

        /// <summary>
        /// 本地数据库文件
        /// </summary>
        string DbFile { get; }

        /// <summary>
        /// 设置DbFile
        /// </summary>
        /// <param name="filename">DBFile文件名</param>
        /// <param name="IsRelativePath">是否相对路径</param>
        /// <returns></returns>
        IDbHelperConfig SetDbFile(string filename, bool IsRelativePath = true);
    }
}