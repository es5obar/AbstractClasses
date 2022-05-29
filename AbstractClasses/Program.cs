using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\source\repos\AbstractClasses\AbstractClasses\File.txt";
            FileOperationBase fileOperation = new FileOperation()
            {
                Path = path
            };
            Console.WriteLine(fileOperation.GetPath());
            Console.WriteLine("***********");
            string content = fileOperation.ReadFromFile();
            Console.WriteLine(content);
            Console.WriteLine("***********");
            Console.Write("Enter content: ");
            string input = Console.ReadLine();

            fileOperation.WriteToFile(input);
            Console.WriteLine("**********");
            content = fileOperation.ReadFromFile();
            Console.WriteLine(content);

            Console.ReadLine();
        }
    }
}
