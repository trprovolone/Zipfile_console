using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zipfile
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = args[0];

            var dirInfo = new DirectoryInfo(path);

            if (!dirInfo.Exists)
            {
                Console.WriteLine("Invalid path.");
                return;
            }
            
            var name = dirInfo.Name;
            var fullName = dirInfo.FullName;

            var files = dirInfo.GetFiles().ToList();
            var folders = dirInfo.GetDirectories().ToList();

            foreach (var file in files)
            {
                var fileName = file.Name;

                Console.WriteLine(fileName);


            }

            foreach (var folder in folders)
            {
                var folderName = folder.Name;
                Console.WriteLine(folderName);
            }

        }
    }
}
