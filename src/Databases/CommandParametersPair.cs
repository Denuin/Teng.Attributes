namespace Teng.Data
{
    /// <summary>
    /// SQL语句及参数列表
    /// </summary>
    public class CommandParametersPair
    {
        /// <summary>
        /// SQL语句
        /// </summary>
        public string CommandText { get; set; }

        /// <summary>
        /// 参数列表
        /// </summary>
        public object[] Parameters { get; set; }
    }
}