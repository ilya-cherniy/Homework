using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTree
{
    public class DirectoryHelper
    {
        public static bool HasValidFiles (DirectoryInfo dir, int daysOld)
        {
            FileInfo[] files = dir.GetFiles();
            int fCount = files.Length;
            for (int i = 0; i < fCount; i++)
            {
                if (FileHelper.IsFileValid(files[i], daysOld))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
