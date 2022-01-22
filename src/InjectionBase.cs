using System;

namespace Teng.Dependencies
{
    /// <summary>
    /// 父类要加[Injection]
    /// </summary>
    public abstract class InjectionBase
    {
        [Resolve]
        public static Func<Type, object> ResolveFunc;

        /// <summary>
        /// 获取Component
        /// </summary>
        public T Resolve<T>()
        {
            return (T)ResolveFunc?.Invoke(typeof(T));
        }
    }
}