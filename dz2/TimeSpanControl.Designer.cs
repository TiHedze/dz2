namespace dz2
{
    using System.Windows.Forms;

    partial class TimeSpanControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateControl1 = new dz2.DateControl();
            this.dateControl2 = new dz2.DateControl();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateControl1
            // 
            this.dateControl1.Location = new System.Drawing.Point(3, 29);
            this.dateControl1.Name = "dateControl1";
            this.dateControl1.Size = new System.Drawing.Size(343, 62);
            this.dateControl1.TabIndex = 0;
            this.dateControl1.Vrijednost = new System.DateTime(2022, 1, 23, 15, 11, 26, 663);
            // 
            // dateControl2
            // 
            this.dateControl2.Location = new System.Drawing.Point(437, 29);
            this.dateControl2.Name = "dateControl2";
            this.dateControl2.Size = new System.Drawing.Size(343, 62);
            this.dateControl2.TabIndex = 1;
            this.dateControl2.Vrijednost = new System.DateTime(2022, 1, 23, 15, 11, 26, 663);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(3, 11);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(49, 15);
            this.startLabel.TabIndex = 2;
            this.startLabel.Text = "Početak";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(437, 11);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(27, 15);
            this.endLabel.TabIndex = 3;
            this.endLabel.Text = "Kraj";
            // 
            // TimeSpanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.dateControl2);
            this.Controls.Add(this.dateControl1);
            this.Name = "TimeSpanControl";
            this.Size = new System.Drawing.Size(783, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DateControl dateControl1;
        public DateControl dateControl2;
        private Label startLabel;
        private Label endLabel;
    }
}
