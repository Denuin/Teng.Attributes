namespace Teng.Attributes
{
    /// <summary>
    /// 约束字符串的长度范围
    /// </summary>
    public class StringRangeAttribute : ValidationAttribute
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public override string ErrorMessage
        {
            get
            {
                if (base.ErrorMessage != null)
                {
                    return base.ErrorMessage;
                }
                return $"字符串长度范围{Min}-{Max}";
            }
            set => base.ErrorMessage = value;
        }

        public override bool IsValid(object value)
        {
            int len = value?.ToString().Length ?? 0;
            return len >= Min && len <= Max;
        }
    }
}