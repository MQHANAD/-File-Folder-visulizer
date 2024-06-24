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
            this.panel2 = new System.Windows.Forms.Panel();
            this.browseButton = new System.Windows.Forms.Button();
            this.barButton = new System.Windows.Forms.Button();
            this.PieButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(238, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 482);
            this.panel2.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(79, 523);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(103, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // barButton
            // 
            this.barButton.Location = new System.Drawing.Point(238, 25);
            this.barButton.Name = "barButton";
            this.barButton.Size = new System.Drawing.Size(103, 23);
            this.barButton.TabIndex = 2;
            this.barButton.Text = "Bar Chart";
            this.barButton.UseVisualStyleBackColor = true;
            // 
            // PieButton
            // 
            this.PieButton.Location = new System.Drawing.Point(384, 25);
            this.PieButton.Name = "PieButton";
            this.PieButton.Size = new System.Drawing.Size(103, 23);
            this.PieButton.TabIndex = 3;
            this.PieButton.Text = "Pie Chart";
            this.PieButton.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(31, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(191, 492);
            this.treeView1.TabIndex = 4;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 567);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.PieButton);
            this.Controls.Add(this.barButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Folder Size visualizer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button barButton;
        private System.Windows.Forms.Button PieButton;
        private System.Windows.Forms.TreeView treeView1;
    }
}

