using System;

namespace Stugo
{
    public class DefaultDateTimeService : IDateTimeService
    {
        public virtual DateTime Now => DateTime.Now;
        public virtual DateTime MinValue { get; } = new DateTime(1753, 1, 1);
        public virtual DateTime MaxValue { get; } = new DateTime(9999, 12, 31);
    }
}
