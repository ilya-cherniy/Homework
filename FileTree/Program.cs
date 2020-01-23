using System;

namespace FileTree
{
    static class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string source = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Chornyi.txt";
            string archivePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Chornyi.gz";

            TreeHelper.CreateTree(path);
            FileHelper.CompressAndDeleteSource(source, archivePath);
        }
    }
}
