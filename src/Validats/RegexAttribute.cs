using System.Text.RegularExpressions;

namespace Teng.Validats
{
    /// <summary>
    /// 约束符合正则表达式
    /// </summary>
    public class RegexAttribute : ValidationAttribute
    {
        public string Pattern { get; set; }

        public override bool IsValid(object value)
        {
            var regex = new Regex(Pattern);
            return regex.Match(value.ToString()).Success;
        }
    }
}