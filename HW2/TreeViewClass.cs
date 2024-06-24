using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Windows.Forms;

namespace HW2
{
    internal class TreeViewClass
    {
        public static void showDrive(string path,TreeView treeView1 )
        {
            treeView1.Nodes.Clear();
            treeView1.BeginUpdate();
            TreeNode tn = new TreeNode(path);
            treeView1.Nodes.Add(tn);
            AddDirs(tn);
            treeView1.EndUpdate();
        }

        public static void AddDirs(TreeNode tn)
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
    }
}
