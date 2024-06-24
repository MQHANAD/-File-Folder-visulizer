using HW2.compositePattern;
using System;
using System.IO;

namespace HW2
{
    internal class ElementsLoop
    {
        public static folder loop(string path)
        {

            try
            {
                if (Directory.Exists(path))
                {
                    DirectoryInfo dinfo = new DirectoryInfo(path);
                    compositePattern.folder fol = new compositePattern.folder(dinfo);

                    FileInfo[] files = dinfo.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        compositePattern.file f = new compositePattern.file(file);
                        fol.GetElements().Add(f);
                    }
                    // Recursively call the method for all subdirectories
                    string[] directories = Directory.GetDirectories(path);
                    foreach (string directory in directories)
                    {
                        DirectoryInfo dinfo2 = new DirectoryInfo(directory);
                        compositePattern.folder fol2 = new compositePattern.folder(dinfo2);
                        fol.GetElements().Add(loop(directory));
                    }
                    return fol;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;

        }
    }
}
