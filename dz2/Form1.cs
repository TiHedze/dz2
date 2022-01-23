namespace dz2
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Drawing2D;
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

        }

        private void OnDvoklik(object sender, DoubleClickEventArgs e)
        {
            this.timeSpanControl1.dateControl1.Vrijednost = e.Date.Item1;
            this.timeSpanControl1.dateControl2.Vrijednost = e.Date.Item2;
        }

        private void OnDateRangeChange(object sender, DateRangeChangedEventArgs e)
        {
            this.Draw(e.Range.Item1, e.Range.Item2);
        }
        private void CreateBlankCanvas() =>
            this.graphControl1.Graph.Image = new Bitmap(this.graphControl1.Width, this.graphControl1.Height); 

        private void graphControl1_Paint(object sender, PaintEventArgs e)
        {
            this.Draw(this.timeSpanControl1.dateControl1.Vrijednost, this.timeSpanControl1.dateControl2.Vrijednost);
        }

        private void Draw(DateTime start, DateTime end)
        {
            var numberOfDays = (int)(end - start).TotalDays;
            var begining = new DateTime(2000, 1, 1);
            
            using var graphics = Graphics.FromImage(this.graphControl1.Graph.Image);
            var paddedHeight = this.graphControl1.Height * 0.9;
            var paddedWidth = this.graphControl1.Width * 0.9;
            
            graphics.DrawLine(
                Pens.Black, 
                new Point(
                    this.graphControl1.Width - (int)paddedWidth, 
                    (int)paddedHeight / 2), 
                new Point(
                    (int)paddedWidth, 
                    (int)paddedHeight / 2)
                );

            var points = new PointF[numberOfDays + 1];
            var dist = (int)(paddedWidth / (numberOfDays + 1));

            foreach(int i in Enumerable.Range(0, numberOfDays))
            {
                points[i] =
                    new PointF(
                        i * dist,
                        (float)Math.Sin(((int)(start - begining).TotalDays + i) / 10)*( (float) paddedHeight / 8) + (float)paddedHeight 
                        );
            }
            
            if(points.Length < 2 )
            {
                return;
            }
            
            graphics.DrawLines(Pens.Black, points);

            this.graphControl1.Invalidate();

            
        }
    }
}