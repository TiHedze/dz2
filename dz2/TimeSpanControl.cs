namespace dz2
{
    using System;
    using System.Windows.Forms;
    public partial class TimeSpanControl : UserControl
    {
        public TimeSpanControl()
        {
            InitializeComponent();
        }

        public delegate void DateRangeChangedEventHandler(object source, DateRangeChangedEventArgs args);

        public event DateRangeChangedEventHandler DateRangeChanged;

        public Tuple<DateTime, DateTime> Raspon
        {
            get => new(this.dateControl1.Vrijednost, this.dateControl2.Vrijednost);
            set
            {
                this.dateControl1.Vrijednost = value.Item1;
                this.dateControl2.Vrijednost = value.Item2;
                this.OnDateRangeChanged();
            }
        }

        public void OnFirstDateChanged(object sender, DateChangedEventArgs args) =>
            this.Raspon = new Tuple<DateTime, DateTime>(args.DateValue, this.Raspon.Item2);

        public void OnSecondDateChanged(object sender, DateChangedEventArgs args) => 
            this.Raspon = new Tuple<DateTime, DateTime>(this.Raspon.Item1, args.DateValue);

        protected virtual void OnDateRangeChanged()
        {
            if(DateRangeChanged is not null)
            {
                DateRangeChanged(this, new() { Range = this.Raspon });
            }
        }
    }
}
