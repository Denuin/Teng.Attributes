namespace Teng.Data
{
    /// <summary>
    /// 数据库字段
    /// </summary>
    public class FieldValue
    {
        /// <summary>
        /// 字段代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 字段值
        /// </summary>
        public object Value { get; set; }
    }
}