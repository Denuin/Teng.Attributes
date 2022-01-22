namespace Teng.Validats
{
    /// <summary>
    /// 数值范围有效性特性
    /// </summary>
    public class NumberRangeAttribute : ValidationAttribute
    {
        /// <summary>
        /// 最小值
        /// </summary>
        public int Min { get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        public int Max { get; set; }

        public override string ErrorMessage
        {
            get
            {
                if (base.ErrorMessage != null)
                {
                    return base.ErrorMessage;
                }
                return $"数值范围{Min}-{Max}";
            }
            set => base.ErrorMessage = value;
        }

        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            if (!int.TryParse(value.ToString(), out int val))
                return false;

            return val >= Min && val <= Max;
        }
    }
}