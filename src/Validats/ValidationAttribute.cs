using System;

namespace Teng.Validats
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public abstract class ValidationAttribute : Attribute
    {
        public virtual string ErrorMessage { get; set; }

        public abstract bool IsValid(object value);
    }
}