using System;
using System.Windows.Forms;
using HW2.compositePattern;
using HW2.Charts;




namespace HW2
{
    public partial class Form1 : Form
    {
        private concreteSub sub = new concreteSub();


        public Form1()
        {
            InitializeComponent();
            chart1.Hide();
            barChartPanel.Hide();
            attachCharts();//Form1.attachCharts()
            TreeViewClass.showDrive("C:\\Users\\Zord\\Documents\\universty", treeView1);//toView this path in the treeView
            createChart(ElementsLoop.loop("C:\\Users\\Zord\\Documents\\universty"));//to go over the files and folders in this path 
        }
        private void attachCharts() // using the observer design pattern 
        {
            sub.Attach(new pieChart(sub, chart1));
            sub.Attach(new BarCharts(sub,  barChartPanel));
        }
        

        private void createChart(folder fold) //this method will change the substate and notify the changes 
        {
            sub.subState = fold.GetElements();
            sub.Notify();
        }
        //tree view #############################################################################################################
        private void browseButton_Click(object sender, EventArgs e)// this method will open a dialog to browse files and folders and pick one of them
        {
            using (var frm = new FolderSelectDialog())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    string path = frm.Folder;
                    TreeViewClass.showDrive(path, treeView1);
                    createChart(ElementsLoop.loop(path));
                }
            }
        }
        
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView1.BeginUpdate();
            foreach (TreeNode tn in e.Node.Nodes)
            {
                TreeViewClass.AddDirs(tn);
            }
            treeView1.EndUpdate();
        }

        private void PieButton_Click(object sender, EventArgs e) //pie Chart Button clicked
        {
            barChartPanel.Hide();
            chart1.Show();
        }

        private void barButton_Click(object sender, EventArgs e) // bar Chart button clicked 
        {
            chart1.Hide();
            barChartPanel.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            createChart(ElementsLoop.loop(treeView1.SelectedNode.FullPath)); 
        }
    }
}
