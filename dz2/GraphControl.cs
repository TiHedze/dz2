namespace dz2
{
    using System;
    using System.Windows.Forms;
    public partial class GraphControl : UserControl
    {
        private Tuple<DateTime, DateTime> date;

        public GraphControl()
        {
            
            InitializeComponent();
            this.CreateControl();
            this.date = new(new DateTime(2000, 1, 1), DateTime.Today);
            this.Raspon = new(new DateTime(2000, 1, 1), DateTime.Today);
        }

        public delegate void DoubleClickEventHandler(object source, DoubleClickEventArgs args);

        public event DoubleClickEventHandler? Dvoklik;

        public Tuple<DateTime, DateTime> Raspon
        {
            get => this.date;
            set
            {
                this.date = value;
            }
        }

        protected virtual void OnDvoklik()
        {
            if (this.Dvoklik is not null)
            {
                Dvoklik(this, new()
                {
                    Date = new(
                        new DateTime(this.Raspon.Item1.Year, 1, 1),
                        new DateTime(this.Raspon.Item2.Year, 12, 31)
                        )
                });

                this.Raspon = new Tuple<DateTime, DateTime>(
                 new DateTime(this.Raspon.Item1.Year, 1, 1),
                 new DateTime(this.Raspon.Item2.Year, 12, 31)
                 );
            }
        }

        private void GraphControl_DoubleClick(object sender, EventArgs e)
        {
            this.OnDvoklik();
        }

        private void Graph_DoubleClick(object sender, EventArgs e)
        {
            this.GraphControl_DoubleClick(sender, e);
        }

        public void OnDateRangeChanged(object sender, DateRangeChangedEventArgs e)
        {
            this.Raspon = e.Range;
        }
    }
}
