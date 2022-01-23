namespace dz2
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.CreateControl();
            this.CreateBlankCanvas();

            this.timeSpanControl1.dateControl1.DateChanged += this.timeSpanControl1.OnFirstDateChanged;
            this.timeSpanControl1.dateControl2.DateChanged += this.timeSpanControl1.OnSecondDateChanged;
            this.graphControl1.Dvoklik += this.OnDvoklik;
            this.timeSpanControl1.DateRangeChanged += this.OnDateRangeChange;
            this.timeSpanControl1.DateRangeChanged += this.graphControl1.OnDateRangeChanged;
            this.ResizeRedraw = true;
        }

        private void OnDvoklik(object sender, DoubleClickEventArgs e)
        {
            this.timeSpanControl1.dateControl1.Vrijednost = e.Date.Item1;
            this.timeSpanControl1.dateControl2.Vrijednost = e.Date.Item2;
        }

        private void OnDateRangeChange(object sender, DateRangeChangedEventArgs e)
        {
            this.Draw(e.Range.Item1, e.Range.Item2, Graphics.FromImage(this.graphControl1.Graph.Image));
        }
        private void CreateBlankCanvas() =>

            this.graphControl1.Graph.Image = new Bitmap(this.graphControl1.Width, this.graphControl1.Height);

        private void graphControl1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.graphControl1.Graph.Image, 0, 0);
        }

        private void Draw(DateTime start, DateTime end, Graphics graphics)
        {
            var numberOfDays = (int)(end - start).TotalDays;
            var begining = new DateTime(2000, 1, 1);
            var pen = new Pen(Color.Black, 5);

            var paddedHeight = this.graphControl1.Graph.Height * 0.9;
            var paddedWidth = this.graphControl1.Graph.Width * 0.9;

            var points = new PointF[numberOfDays + 1];

            var dist = (int)(paddedWidth / (numberOfDays + 1));

            foreach (int i in Enumerable.Range(0, numberOfDays))
            {
                points[i] =
                    new PointF(
                        i * dist,
                        (float)Math.Sin(((int)(start - begining).TotalDays + i) / 10)*((float)paddedHeight / (float)5) + (float)paddedHeight
                        );
            }

            if (points.Length < 2)
            {
                graphics.DrawLine(
                pen,
                new Point(
                    0,
                    (int)paddedHeight / 2),
                new Point(
                    this.graphControl1.Graph.Width,
                    (int)paddedHeight / 2)
                );

            }

            else
            {
                graphics.DrawLines(pen, points);
            }

            this.graphControl1.Invalidate();

        }
    }
}