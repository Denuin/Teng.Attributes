using System;

namespace Teng.Validats
{
    /// <summary>
    /// 有效性特性基类
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public abstract class ValidationAttribute : Attribute
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public abstract bool IsValid(object value);
    }
}