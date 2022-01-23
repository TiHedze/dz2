namespace dz2
{
    using System;

    public class DoubleClickEventArgs : EventArgs
    {
        public Tuple<DateTime, DateTime> Date;
    }
}
