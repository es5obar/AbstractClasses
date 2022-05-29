using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class FileOperationBase // soyut, new'lenemez
    {
        public string Path { get; set; }

        public virtual string ReadFromFile()
        {
            return File.ReadAllText(Path);
        }

        public virtual void WriteToFile(string content)
        {
            File.WriteAllText(Path, content);
        }

        public abstract string GetPath();
    }
}
