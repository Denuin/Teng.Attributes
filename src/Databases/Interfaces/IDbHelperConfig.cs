namespace Teng.Data.Interfaces
{
    public interface IDbHelperConfig
    {
        string ConnectionString { get; }
        string DbFile { get; }

        IDbHelperConfig SetDbFile(string filename, bool IsRelativePath = true);
    }
}