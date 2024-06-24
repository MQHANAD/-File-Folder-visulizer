namespace HW2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.browseButton = new System.Windows.Forms.Button();
            this.barButton = new System.Windows.Forms.Button();
            this.PieButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barChartPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.browseButton.Location = new System.Drawing.Point(79, 516);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(103, 33);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // barButton
            // 
            this.barButton.AutoSize = true;
            this.barButton.Location = new System.Drawing.Point(247, 18);
            this.barButton.Name = "barButton";
            this.barButton.Size = new System.Drawing.Size(103, 33);
            this.barButton.TabIndex = 2;
            this.barButton.Text = "Bar Chart";
            this.barButton.UseVisualStyleBackColor = true;
            this.barButton.Click += new System.EventHandler(this.barButton_Click);
            // 
            // PieButton
            // 
            this.PieButton.AutoSize = true;
            this.PieButton.Location = new System.Drawing.Point(372, 18);
            this.PieButton.Name = "PieButton";
            this.PieButton.Size = new System.Drawing.Size(103, 33);
            this.PieButton.TabIndex = 3;
            this.PieButton.Text = "Pie Chart";
            this.PieButton.UseVisualStyleBackColor = true;
            this.PieButton.Click += new System.EventHandler(this.PieButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(37, 18);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(191, 492);
            this.treeView1.TabIndex = 4;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ia0x0hzj5vs71.png");
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(247, 63);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "S1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(735, 486);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // barChartPanel
            // 
            this.barChartPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barChartPanel.AutoScroll = true;
            this.barChartPanel.BackColor = System.Drawing.SystemColors.Window;
            this.barChartPanel.Location = new System.Drawing.Point(247, 63);
            this.barChartPanel.Name = "barChartPanel";
            this.barChartPanel.Size = new System.Drawing.Size(735, 486);
            this.barChartPanel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 576);
            this.Controls.Add(this.barChartPanel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.PieButton);
            this.Controls.Add(this.barButton);
            this.Controls.Add(this.browseButton);
            this.Name = "Form1";
            this.Text = "Folder Size visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button barButton;
        private System.Windows.Forms.Button PieButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel barChartPanel;
    }
}

