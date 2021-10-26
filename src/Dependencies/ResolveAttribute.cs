using System;

namespace Teng.Dependencies
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class ResolveAttribute : Attribute
    {
    }
}