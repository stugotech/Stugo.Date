using System;
using System.Globalization;

namespace Stugo
{
    public static class DateExtensions
    {
        /// <summary>
        /// Gets the week number of the given date according to the current culture.
        /// </summary>
        public static int GetWeekNumber(this DateTime date)
        {
            var currentCulture = CultureInfo.CurrentCulture;
            return currentCulture.Calendar.GetWeekOfYear(date,
                currentCulture.DateTimeFormat.CalendarWeekRule,
                currentCulture.DateTimeFormat.FirstDayOfWeek);
        }


        /// <summary>
        /// Gets the zero-based day number of the given date according to the current culture.
        /// </summary>
        public static int GetLocalDayNumber(this DateTime date)
        {
            return (7 + date.DayOfWeek - CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek) % 7;
        }


        /// <summary>
        /// Converts the given local day number into a DayOfWeek value.
        /// </summary>
        public static DayOfWeek GetDay(this DateTimeFormatInfo format, int dayNumber)
        {
            return (DayOfWeek)((int)(dayNumber + format.FirstDayOfWeek) % 7);
        }
    }
}
