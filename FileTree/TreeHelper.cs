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

            for (int j = 0; j < subdirs.Length; j++)
            {
                try
                {
                    if (j == subdirs.Length - 1)
                    {
                        if (DirectoryHelper.HasValidFiles(subdirs[j], daysOld))
                        {
                            FileHelper.WriteToFile(prefix + "|___ " + subdirs[j].Name);
                            CreateTree(subdirs[j].FullName, prefix + "    ");
                        }
                    }
                    else
                    {
                        if (DirectoryHelper.HasValidFiles(subdirs[j], daysOld))
                        {
                            FileHelper.WriteToFile(prefix + "|--- " + subdirs[j].Name);
                            CreateTree(subdirs[j].FullName, prefix + "|   ");
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
            }
            for (int i = 0; i < files.Length; i++)
            {
                try
                {
                    if (FileHelper.IsFileValid(files[i],daysOld))
                    {
                        if (i == files.Length - 1)
                            if (FileHelper.IsFileValid(files[i], daysOld))
                            {
                            FileHelper.WriteToFile(prefix + "|___ " + files[i].Name);
                            }
                        else
                            if (FileHelper.IsFileValid(files[i], daysOld))
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
