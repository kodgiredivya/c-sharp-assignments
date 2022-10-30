using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace directoryinfoproperty
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = "thermopylae.txt";

            using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            using var sr = new StreamReader(fs, Encoding.UTF8);

            string content = sr.ReadToEnd();

            Console.WriteLine(content);

            DirectoryInfo fi = new DirectoryInfo(path);
            Console.WriteLine("Directory name is {0} ", fi.Name);
            Console.WriteLine("Directory creation time is {0} ", fi.CreationTime.ToLongTimeString());
            Console.WriteLine("Directory Lastaccesstime is {0} ", fi.LastAccessTime.ToLongDateString());
            Console.WriteLine("Directory exist is: ", fi.Exists);
            Console.WriteLine("Directory LastWriteTime is {0} ", fi.LastWriteTime);
            Console.WriteLine("Directory root is {0} ", fi.Root);

            try
            {
                DirectoryInfo di = new DirectoryInfo(@"C:\newFile");
                DirectoryInfo[] dir1 = di.GetDirectories();
                Console.WriteLine("The number of directories containing is {0}.", dir1.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

        }
    }
}