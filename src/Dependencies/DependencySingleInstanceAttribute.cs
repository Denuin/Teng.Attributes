using System;

namespace Teng.Dependencies
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DependencySingleInstanceAttribute : Attribute
    {
    }
}