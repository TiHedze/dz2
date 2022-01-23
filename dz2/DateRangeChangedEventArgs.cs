namespace dz2
{
    using System;

    public class DateRangeChangedEventArgs: EventArgs
    {
        public Tuple<DateTime, DateTime>? Range = default;
    }
}
