namespace dz2
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.timeSpanControl1.dateControl1.DateChanged += this.timeSpanControl1.OnFirstDateChanged;
            this.timeSpanControl1.dateControl2.DateChanged += this.timeSpanControl1.OnSecondDateChanged;
        }
    }
}