namespace Teng.Validats
{
    /// <summary>
    /// 约束属性不能为空有效性特性
    /// </summary>
    public class RequiredAttribute : ValidationAttribute
    {
        public override string ErrorMessage
        {
            get
            {
                if (base.ErrorMessage != null)
                {
                    return base.ErrorMessage;
                }
                return "属性不能为空";
            }
            set => base.ErrorMessage = value;
        }

        public override bool IsValid(object value)
        {
            return !(value is null);
        }
    }
}