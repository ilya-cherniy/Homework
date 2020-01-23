using System;
using System.IO;

namespace FileTree
{
    public class TreeHelper
    {
        public static void CreateTree(string startDir, string prefix = "", int daysOld = 14)
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
                        FileHelper.WriteToFile(prefix + "|___ " + subdirs[j].Name);
                        CreateTree(subdirs[j].FullName, prefix + "    ");
                    }
                    else
                    {
                        FileHelper.WriteToFile(prefix + "|--- " + subdirs[j].Name);
                        CreateTree(subdirs[j].FullName, prefix + "|   ");
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
            }
            for (int i = 0; i < fCount; i++)
            {
                try
                {
                    if (DateTime.Now.Subtract(files[i].CreationTime).TotalDays <= daysOld)
                    {
                        if (i == fCount - 1)
                        {
                            FileHelper.WriteToFile(prefix + "|___ " + files[i].Name);
                        }
                        else
                        {
                            FileHelper.WriteToFile(prefix + "|--- " + files[i].Name);
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
            }
        }
    }
}
