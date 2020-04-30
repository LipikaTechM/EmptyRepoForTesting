using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Fileinfo {
    class Program {
        static void Main(string[] args) {
            // Make a reference to a directory.
            DirectoryInfo di = new DirectoryInfo("C:\\Lipika\\Fileinfo\\FileSize");
            // Get a reference to each file in that directory.
            FileInfo[] fiArr = di.GetFiles();
            // Display the names and sizes of the files.
            Console.WriteLine("The directory {0} contains the following files:", di.Name);
            long fileSize = 0;
            foreach (FileInfo fi in di.GetFiles()) {
                string fname = fi.FullName.ToString().Trim();
                if (File.Exists(fname)) {
                    fileSize = fi.Length;
                       Console.WriteLine("Validating {0}", fname);
                    if (fileSize > 0 && !string.IsNullOrEmpty(Path.GetExtension(fname))) {
                        Console.WriteLine("size is grater than zero");
                        //Console.ReadLine();

                    } else {
                        Console.WriteLine("size is Zero and does not contain extension" + ":" + fi.Name);
                        //Console.ReadLine();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
