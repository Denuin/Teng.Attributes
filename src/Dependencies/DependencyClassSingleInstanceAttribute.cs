using System;

namespace Teng.Dependencies
{
    /// <summary>
    /// 通过类Resolve（单例）
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DependencyClassSingleInstanceAttribute : Attribute
    {
    }
}