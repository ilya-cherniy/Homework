using System;
using System.IO;
using System.Text;

namespace FileTree
{
    static class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Chornyi.txt";

            CreateTree(path);

            void WriteToFile(string data)
            {
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default))
                {
                    sw.WriteLine(data);
                }
            }

            void CreateTree(string startDir, string prefix = "")
            {
                var dir = new DirectoryInfo(startDir);
                FileInfo[] files = dir.GetFiles();
                DirectoryInfo[] subdirs = dir.GetDirectories();
                int fCount = files.Length;
                int dirCount = subdirs.Length;

                for (int j = 0; j < dirCount; j++)
                  {
                      try
                       {
                           if (j == dirCount - 1)
                           {
                               WriteToFile(prefix + "|___ " + subdirs[j].Name);
                               CreateTree(subdirs[j].FullName, prefix + "    ");
                            }
                            else
                            {
                               WriteToFile(prefix + "|--- " + subdirs[j].Name);
                               CreateTree(subdirs[j].FullName, prefix + "|   ");
                            }
                        }
                        catch
                        {
                            return;
                        }
                    }
                    for (int i = 0; i < fCount; i++)
                    {
                        if (DateTime.Now.Subtract(files[i].CreationTime).TotalDays <= 14)
                        {
                            if (i == fCount - 1)
                            {
                               WriteToFile(prefix + "|___ " + files[i].Name);
                            }
                            else
                            {
                               WriteToFile(prefix + "|--- " + files[i].Name);
                            }
                        }
                    }
            }
        }
    }
}
