using System;

namespace Teng.Dependencies
{
    /// <summary>
    /// 用于注入Resolve方法
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class ResolveAttribute : Attribute
    {
    }
}