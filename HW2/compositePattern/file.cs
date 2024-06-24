using System.IO;


namespace HW2.compositePattern
{
    internal class file : StorageElement
    {
        private string name;
        private long size;
        private string extension;
        public file (FileInfo file1)
        {
            this.name = file1.Name;
            this.size = file1.Length;
            this.extension = file1.Extension;
        }

        public override string getName()
        {
            return name;
        }

        public override long getSize()
        {
            return size;
        }
        public override string ToString()
        {
            double s = size / 1000;
            return "( " + s.ToString("0.00") + " KB ) " + name;
        }

       

        internal override string getPath()
        {
            return "empty";
        }
    }
}
