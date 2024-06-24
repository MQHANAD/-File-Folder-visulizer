using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Reflection.Emit;
using Label = System.Windows.Forms.Label;


namespace HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showDrive();

        }

        internal void loop(string path)
        {
            compositePattern.folderContainer folderContainer = new compositePattern.folderContainer();  
            
            try
            {
                // Display the current directory
                Console.WriteLine("Directory: " + path);

                // Display all files in the current directory
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    Console.WriteLine("File: " + file);
                }

                // Recursively call the method for all subdirectories
                string[] directories = Directory.GetDirectories(path);
                foreach (string directory in directories)
                {
                    loop(directory);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var frm = new FolderSelectDialog())
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    treeView1.Nodes.Clear();
                    //DirectoryInfo di = new DirectoryInfo(frm.Folder);
                    treeView1.BeginUpdate();
                    TreeNode tn = new TreeNode(frm.Folder);
                    treeView1.Nodes.Add(tn);
                    AddDirs(tn);
                    treeView1.EndUpdate();
                }

            }
        }

        public void showDrive()
        {
            treeView1.BeginUpdate();
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives) {
                TreeNode tn = new TreeNode(drive);
                treeView1.Nodes.Add(tn);
                AddDirs(tn);    
            }
            treeView1.EndUpdate();
        }
        public void AddDirs (TreeNode tn)
        {
            string path = tn.FullPath;
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] diArray = { };

            try
            {
                if (di.Exists)
                {
                    diArray = di.GetDirectories();
                }
            }
            catch
            {
                return;
            }
            foreach (DirectoryInfo d in diArray)
            {
                TreeNode tndir = new TreeNode(d.Name);
                tn.Nodes.Add(tndir);
            }
        }

       

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView1.BeginUpdate();
            foreach (TreeNode tn in e.Node.Nodes)
            {
                AddDirs(tn);
            }
            treeView1.EndUpdate();
        }
    }
}
