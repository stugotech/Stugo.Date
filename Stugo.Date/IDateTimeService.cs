using System;

namespace Stugo
{
    public interface IDateTimeService
    {
        DateTime Now { get; }
        DateTime MinValue { get; }
        DateTime MaxValue { get; }
    }
}
