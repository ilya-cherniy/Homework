using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTree
{
    static class Program
    {
        static void Main(string[] args)
        {
            //string startDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string path = @"D:\Programming Net";
            PrintTree(path);

            void PrintTree(string startDir)
            {
                var dirs = new DirectoryInfo(startDir);
                foreach (var item in dirs.GetDirectories())
                {
                    Console.WriteLine("├── "+item.Name);
                    foreach (var file in item.GetFiles())
                    {
                        Console.WriteLine("   ├── "+file.Name);
                    }
                 PrintTree(item.FullName);
                    
                }

                //var rootFiles = new DirectoryInfo(startDir);
                //foreach (var rootFile in rootFiles.GetFiles())
                //{
                //    Console.WriteLine(rootFile.Name);
                //}
                //var rootFiles = Directory.GetFiles(startDir);
                //foreach (var item in rootFiles)
                //{
                //    Console.WriteLine(item);
                //}
            }

            ////Console.WriteLine("GetFolderPath: {0}", path);
            //DirectoryInfo dir = new DirectoryInfo(path);
            // foreach (var item in dir.GetDirectories())
            // {
            //     Console.WriteLine(item.Name);
            //     foreach (var sub in item.GetDirectories())
            //     {
            //         Console.WriteLine(sub.Name);
            //         Console.WriteLine();
            //     }
            // }
            //foreach (var item in dir.GetFiles())
            // {
            //     Console.WriteLine(item.Name);
            // }
            // PrintTree(startDir);
            //}
            //public static bool IsDirectory(this FileSystemInfo fsItem)
            //{
            //    return (fsItem.Attributes & FileAttributes.Directory) == FileAttributes.Directory;
            //}
            //static void PrintTree(string startDir, string prefix = "")
            //{
            //    var di = new DirectoryInfo(startDir);
            //    var fsItems = di.GetFileSystemInfos()
            //        //.Where(f => DateTime.Now.Subtract(f.CreationTime).TotalDays <= 14) // 14 days
            //        //.OrderBy(f => f.Name)
            //        .ToList();

            //    for (int i = 0; i < fsItems.Count; i++)
            //    {

            //        var fsItem = fsItems[i];

            //        if (i == fsItems.Count - 1)
            //        {
            //            Console.Write(prefix + "└── ");
            //            Console.WriteLine(fsItem);
            //            //Console.WriteLine();
            //            if (fsItem.IsDirectory())
            //            {
            //                PrintTree(fsItem.FullName, prefix + "    ");
            //            }
            //        }
            //        else
            //        {
            //            Console.Write(prefix + "├── ");
            //            Console.WriteLine(fsItem);
            //            //Console.WriteLine();
            //            if (fsItem.IsDirectory())
            //            {
            //                PrintTree(fsItem.FullName, prefix + "│   ");
            //            }
            //        }


            //    }
            //}
        }
    }
}
