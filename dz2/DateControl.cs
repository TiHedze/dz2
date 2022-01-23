namespace dz2
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class DateControl : UserControl
    {
        public DateControl()
        {
            InitializeComponent();

            this.Vrijednost = DateTime.Today;
        }

        public delegate void DateChangedEventHandler(object source, DateChangedEventArgs args);

        public event DateChangedEventHandler DateChanged;

        private DateTime vrijednost;
        public DateTime Vrijednost
        {
            get => this.vrijednost;
            set
            {
                this.vrijednost = value;
                this.DayTextBox.Text = value.Day.ToString();
                this.MonthTextBox.Text = value.Month.ToString();
                this.YearTextBox.Text = value.Year.ToString();
                this.OnDateChanged();
            }
        }

        private void SetInputBackgroundColor(Color color)
        {
            this.DayTextBox.BackColor = color;
            this.MonthTextBox.BackColor = color;
            this.YearTextBox.BackColor = color;
        }
        private void DateControl_Load(object sender, EventArgs e)
        {
            var today = DateTime.Today;

            this.DayTextBox.Text = today.Day.ToString();
            this.MonthTextBox.Text = today.Month.ToString();
            this.YearTextBox.Text = today.Year.ToString();
        }

        private void DateControl_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (int.TryParse(this.DayTextBox.Text, out int day) &&
                int.TryParse(this.MonthTextBox.Text, out int month) &&
                int.TryParse(this.YearTextBox.Text, out int year) &&
                TryParseDate(day, month, year, out var date))
            {
                this.SetInputBackgroundColor(Color.White);
                this.Vrijednost = date;
            }
            else
            {
                this.SetInputBackgroundColor(Color.Red);
            }
        }

        private static bool TryParseDate(int day, int month, int year, out DateTime date)
        {
            date = default;

            if (DateTime.MinValue.Year <= year && year < DateTime.MaxValue.Year &&
                0 < month && month < 13 &&
                0 < day && day <= DateTime.DaysInMonth(year, month))
            {
                date = new DateTime(year, month, day);
                return true;
            }
            return false;
        }

        protected virtual void OnDateChanged()
        {
            if(DateChanged is not null)
            {
                DateChanged(this, new() { DateValue = this.Vrijednost });
            }
        }
    }
}
