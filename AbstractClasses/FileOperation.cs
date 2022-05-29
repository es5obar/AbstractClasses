using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class FileOperation : FileOperationBase
    {
        public override void WriteToFile(string content)
        {
            StreamWriter writer = new StreamWriter(Path, true);
            writer.WriteLine(content);
            writer.Close();

        }

        public override string ReadFromFile()
        {
            StreamReader reader = new StreamReader(Path);

            //string content = reader.ReadToEnd();
            string content = "";
            string line;
            int sayi = 1;
            while ((line = reader.ReadLine()) != null)
            {
                content += sayi + ". " + line + "\n";
                sayi++;
            }

            reader.Close();
            return content;
        }

    }
}
