using System;

namespace Teng.Dependencies
{
    /// <summary>
    /// 通过接口Resolve（单例）
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DependencySingleInstanceAttribute : Attribute
    {
    }
}