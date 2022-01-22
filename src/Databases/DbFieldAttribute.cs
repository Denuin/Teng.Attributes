using System;

namespace Teng.Data
{
    /// <summary>
    /// 数据库字段特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DbFieldAttribute : Attribute
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 字段代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        public string SQLType { get; set; }
    }
}