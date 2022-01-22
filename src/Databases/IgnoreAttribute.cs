using System;

namespace Teng.Data
{
    /// <summary>
    /// 字段忽略特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class IgnoreAttribute : Attribute
    {
    }
}