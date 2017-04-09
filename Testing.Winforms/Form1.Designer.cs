namespace Testing.Winforms
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Media.SolidColorBrush solidColorBrush1 = new System.Windows.Media.SolidColorBrush();
            this.dopGraph = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // dopGraph
            // 
            this.dopGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dopGraph.Hoverable = true;
            this.dopGraph.Location = new System.Drawing.Point(0, 0);
            this.dopGraph.Name = "dopGraph";
            solidColorBrush1.Color = System.Windows.Media.Color.FromArgb(((byte)(30)), ((byte)(30)), ((byte)(30)), ((byte)(30)));
            this.dopGraph.ScrollBarFill = solidColorBrush1;
            this.dopGraph.ScrollHorizontalFrom = 0D;
            this.dopGraph.ScrollHorizontalTo = 0D;
            this.dopGraph.ScrollMode = LiveCharts.ScrollMode.None;
            this.dopGraph.ScrollVerticalFrom = 0D;
            this.dopGraph.ScrollVerticalTo = 0D;
            this.dopGraph.Size = new System.Drawing.Size(538, 337);
            this.dopGraph.TabIndex = 0;
            this.dopGraph.Text = "cartesianChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 337);
            this.Controls.Add(this.dopGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart dopGraph;
    }
}

