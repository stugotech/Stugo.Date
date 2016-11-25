using System;

namespace Stugo
{
    public class DateTimeService
    {
        public static IDateTimeService Default { get; } = new DefaultDateTimeService();

        public static DateTime Now => Default.Now;
        public static DateTime Today => Default.Now.Date;


        /// <summary>
        /// Get the gregorian epoch, long enough ago for practical purposes and recent enough to
        /// enjoy broad support in databases (specifically MS SQL).
        /// </summary>
        public static DateTime MinValue { get; } = Default.MinValue;


        /// <summary>
        /// Get the last date broadly supported in various database engines.
        /// </summary>
        public static DateTime MaxValue { get; } = Default.MaxValue;
    }
}
