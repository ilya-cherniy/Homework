using System.IO;

namespace FileTree
{
    public class DirectoryHelper
    {
        public static bool HasValidFiles (DirectoryInfo dir, int daysOld)
        {
            FileInfo[] files = dir.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                if (FileHelper.IsFileValid(files[i], daysOld))
                {
                    return true;
                }
            }
            DirectoryInfo[] subdirs = dir.GetDirectories();
            for (int i = 0; i < subdirs.Length; i++)
            {
                if (HasValidFiles(subdirs[i], daysOld))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
