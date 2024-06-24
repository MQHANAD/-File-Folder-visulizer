using System.Collections.Generic;
using System.IO;


namespace HW2.compositePattern
{
    internal class folder : StorageElement
    {
        private string name;
        private long size;
        private string path;
        private List<StorageElement> Elements;

        public folder(DirectoryInfo d)  
        {
            
            this.name = d.Name;
            this.path = d.FullName;
            Elements = new List<StorageElement>();   
        }

        
        public List<StorageElement> GetElements() {  return Elements; }
        public void add(StorageElement e)
        {
            Elements.Add(e);
            size += e.getSize();
        }
        public override long getSize()
        {

            foreach (StorageElement fi in Elements)
            {
                size += fi.getSize();
            }
            return size;
        }

        public override string getName()
        {
            return name;
        }
        public override string ToString()
        {
            double s = size / 1000;
            return "( "+s.ToString("0.00")+" KB ) "+ name ;
        }
        internal override string getPath()
        {
            return path;    
        }
    }
}
