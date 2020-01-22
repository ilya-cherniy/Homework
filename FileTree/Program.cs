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
            string path = @"C:\Work\Pfister";
            PrintTree(path);

            void PrintTree(string startDir, string prefix = "")
            {
                var dir = new DirectoryInfo(startDir);
                FileInfo[] files = dir.GetFiles();
                DirectoryInfo[] subdirs = dir.GetDirectories();
                int fCount = files.Length;
                int dirCount = subdirs.Length;

                for (int j = 0; j < dirCount; j++)
                {
                    if (j == dirCount - 1)
                    {
                        Console.WriteLine(prefix + "└── " + subdirs[j].Name);
                        PrintTree(subdirs[j].FullName, prefix + "    ");
                    }
                    else
                    {
                        Console.WriteLine(prefix + "├── " + subdirs[j].Name);
                        PrintTree(subdirs[j].FullName, prefix + "│   ");
                    }
                }
                for (int i = 0; i < fCount; i++)
                {
                    if (i == fCount - 1)
                    {
                        Console.WriteLine(prefix + "└── " + files[i].Name);
                    }
                    else
                    {
                        Console.WriteLine(prefix + "├── " + files[i].Name);
                    }
                }
            }
        }
    }
}
