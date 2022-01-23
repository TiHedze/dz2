namespace dz2
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class GraphControl : UserControl
    {
        private readonly Graphics graphics;
        private bool canDraw = true;
        public GraphControl()
        {
            InitializeComponent();

            this.graphics = this.Graph.CreateGraphics();
        }

        private Tuple<DateTime, DateTime> date;
        public Tuple<DateTime, DateTime> Raspon
        {
            get => this.date;
            set
            {
                this.date = value;
                this.Draw();
            }
        }

        private void Draw()
        {
            if (this.canDraw)
            {
                this.canDraw = false;
                var pen = new Pen(Color.Black);
                var paddedHeight = this.Graph.Height * 0.9;
                var paddedWidth = this.Graph.Width * 0.9;
                this.graphics.DrawLine(pen, new Point(0, (int)paddedHeight / 2), new Point((int)paddedWidth, (int)paddedWidth / 2));
                

                this.canDraw = true;
            }

        }
    }
}
