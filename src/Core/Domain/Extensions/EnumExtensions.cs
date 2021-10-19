using System;
using System.ComponentModel;

namespace Domain.Extensions
{
    public static class EnumExtensions
    {
        public static string ToDescriptionString(this Enum @this)
        {
            var attributes = (DescriptionAttribute[])@this.GetType().GetField(@this.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0
                ? attributes[0].Description
                : @this.ToString();
        }
    }
}
