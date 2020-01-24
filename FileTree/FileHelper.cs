using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace FileTree
{
    public class FileHelper
    {

        string source = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Chornyi.txt";
        string archivePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Chornyi.gz";
        
        public static void WriteToFile(string data)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Chornyi.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default))
            {
                sw.WriteLine(data);
            }
        }

        public static bool IsFileValid (FileInfo file, int daysOld)
        {
            if (DateTime.Now.Subtract(file.LastWriteTime).TotalDays <= daysOld)
                return true;
            else
                return false;
        }

        public static void CompressAndDeleteSource(string source, string archivePath)
        {
            using (FileStream fs = new FileStream(source, FileMode.OpenOrCreate))
            {
                using (FileStream dfs = File.Create(archivePath))
                {
                    using (GZipStream gzs = new GZipStream(dfs, CompressionMode.Compress))
                    {
                        fs.CopyTo(gzs);
                    }
                }
            }
        FileInfo file = new FileInfo(source);
            if (file.Exists)
            {
                file.Delete();
            }
        }
    }
}
