using System;

namespace WebBase.Core
{
    public class WebBaseUtils
    {
        public static DateTime Now()
        {
            return DateTime.UtcNow.AddHours(7);
        }
    }
}
