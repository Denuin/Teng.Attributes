using System;

namespace Teng.Data
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string Code { get; set; }
        public TableAttribute(string code)
        {
            Code = code;
        }
    }
}