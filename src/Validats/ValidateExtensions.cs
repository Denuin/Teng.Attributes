using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Teng.Attributes
{
    public static class ValidateExtensions
    {
        public static string Validate<T>(this T _input)
        {
            Type type = _input.GetType();

            PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            List<string> ErrorList = new List<string>();
            foreach (PropertyInfo p in propertyInfos)
            {
                var lstp = p.GetCustomAttributes(false).Where(a => a is ValidationAttribute).Select(a => a as ValidationAttribute);
                if (lstp != null)
                {
                    foreach (var attr in lstp)
                    {
                        if (!attr.IsValid(p.GetValue(_input, null)))
                        {
                            ErrorList.Add($"[{p.Name}]" + attr.ErrorMessage);
                        }
                    }
                }
            }
            return string.Join(",", ErrorList.ToArray());
        }
    }
}