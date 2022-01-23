namespace dz2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.graphControl1 = new dz2.GraphControl();
            this.timeSpanControl1 = new dz2.TimeSpanControl();
            this.SuspendLayout();
            // 
            // graphControl1
            // 
            this.graphControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.graphControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.graphControl1.Location = new System.Drawing.Point(0, 105);
            this.graphControl1.Name = "graphControl1";
            this.graphControl1.Size = new System.Drawing.Size(932, 362);
            this.graphControl1.TabIndex = 1;
            this.graphControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphControl1_Paint);
            // 
            // timeSpanControl1
            // 
            this.timeSpanControl1.AutoSize = true;
            this.timeSpanControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timeSpanControl1.Location = new System.Drawing.Point(0, 0);
            this.timeSpanControl1.Name = "timeSpanControl1";
            this.timeSpanControl1.Raspon = ((System.Tuple<System.DateTime, System.DateTime>)(resources.GetObject("timeSpanControl1.Raspon")));
            this.timeSpanControl1.Size = new System.Drawing.Size(783, 94);
            this.timeSpanControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(932, 467);
            this.Controls.Add(this.timeSpanControl1);
            this.Controls.Add(this.graphControl1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "DZ2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GraphControl graphControl1;
        private TimeSpanControl timeSpanControl1;
    }
}