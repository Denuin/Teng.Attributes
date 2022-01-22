using System;

namespace Teng.Data
{
    /// <summary>
    /// 主键
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class PrimaryKeyAttribute : Attribute
    {
    }
}