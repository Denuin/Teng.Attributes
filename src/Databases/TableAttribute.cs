using System;

namespace Teng.Data
{
    /// <summary>
    /// 数据库表
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        /// <summary>
        /// 表名
        /// </summary>
        public string Code { get; set; }

        public TableAttribute(string code) => Code = code;
    }
}