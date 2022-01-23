namespace dz2
{
    using System.Windows.Forms;

    partial class DateControl
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
            this.DayTextBox = new System.Windows.Forms.TextBox();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.DayLabel = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DayTextBox
            // 
            this.DayTextBox.Location = new System.Drawing.Point(3, 22);
            this.DayTextBox.Name = "DayTextBox";
            this.DayTextBox.Size = new System.Drawing.Size(100, 23);
            this.DayTextBox.TabIndex = 0;
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Location = new System.Drawing.Point(121, 22);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(100, 23);
            this.MonthTextBox.TabIndex = 1;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(240, 22);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(100, 23);
            this.YearTextBox.TabIndex = 2;
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(3, 4);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(28, 15);
            this.DayLabel.TabIndex = 3;
            this.DayLabel.Text = "Dan";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(121, 4);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(44, 15);
            this.MonthLabel.TabIndex = 4;
            this.MonthLabel.Text = "Mjesec";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(240, 4);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(45, 15);
            this.YearLabel.TabIndex = 5;
            this.YearLabel.Text = "Godina";
            // 
            // DateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.DayTextBox);
            this.Name = "DateControl";
            this.Size = new System.Drawing.Size(343, 62);
            this.Load += new System.EventHandler(this.DateControl_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.DateControl_Validating);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox DayTextBox;
        private TextBox MonthTextBox;
        private TextBox YearTextBox;
        private Label DayLabel;
        private Label MonthLabel;
        private Label YearLabel;
    }
}
