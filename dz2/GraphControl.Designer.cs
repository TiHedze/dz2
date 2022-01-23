namespace dz2
{
    partial class GraphControl
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
            this.Graph = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(3, 3);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(715, 340);
            this.Graph.TabIndex = 0;
            this.Graph.TabStop = false;
            this.Graph.DoubleClick += new System.EventHandler(this.Graph_DoubleClick);
            // 
            // GraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.Graph);
            this.Name = "GraphControl";
            this.Size = new System.Drawing.Size(721, 346);
            this.DoubleClick += new System.EventHandler(this.GraphControl_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox Graph;
    }
}
