using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trash
{
    static class Program
    {
        static void Main(string[] args)
        {
            //string startDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string startDir = @"C:\Users\ilyac\source";
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
            PrintTree(startDir);
        }
        public static bool IsDirectory(this FileSystemInfo fsItem)
        {
            return (fsItem.Attributes & FileAttributes.Directory) == FileAttributes.Directory;
        }
        static void PrintTree(string startDir, string prefix = "")
        {
            var di = new DirectoryInfo(startDir);
            var fsItems = di.GetFileSystemInfos()
                .Where(f => DateTime.Now.Subtract(f.CreationTime).TotalDays <= 14) // 14 days
                //.OrderBy(f => f.Name)
                .ToList();

            for (int i = 0; i < fsItems.Count; i++)
            {

                var fsItem = fsItems[i];

                if (i == fsItems.Count - 1)
                {
                    Console.Write(prefix + "└── ");
                    Console.WriteLine(fsItem);
                    //Console.WriteLine();
                    if (fsItem.IsDirectory())
                    {
                        PrintTree(fsItem.FullName, prefix + "    ");
                    }
                }
                else
                {
                    Console.Write(prefix + "├── ");
                    Console.WriteLine(fsItem);
                    //Console.WriteLine();
                    if (fsItem.IsDirectory())
                    {
                        PrintTree(fsItem.FullName, prefix + "│   ");
                    }
                }


            }
        }
    }
}
