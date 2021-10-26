using System;

namespace Teng.Data
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DbFieldAttribute : Attribute
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string SQLType { get; set; }
    }
}