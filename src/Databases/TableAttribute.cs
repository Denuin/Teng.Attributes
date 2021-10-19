using System;

namespace Teng.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string Code { get; set; }
    }
}