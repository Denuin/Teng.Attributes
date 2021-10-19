namespace Teng.Attributes
{
    /// <summary>
    /// 数值范围
    /// </summary>
    public class NumberRangeAttribute : ValidationAttribute
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