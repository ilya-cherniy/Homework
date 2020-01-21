using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectFive
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string path = @"C:\Work\test.txt";
            FileInfo file = new FileInfo(path);

            //if (file.Exists)
            //{
            //    Console.WriteLine($"File name: {file.Name}");
            //    Console.WriteLine($"File creation datetime: {file.CreationTime}");
            //    Console.WriteLine($"File size: {file.Length}");

            //    /*2 variants of delete file
            //    FileInfo save path to file instead of File*/
            //    file.Delete();
            //    File.Delete(path);
            //}
            //Console.WriteLine("123"+Environment.NewLine+"456");
            //file.Create();
            //file.MoveTo(@"C:\Work\test2.txt");
            //if (file.Exists)
            //{
            //    Console.WriteLine($"File name: {file.Name}");
            //    Console.WriteLine($"File creation datetime: {file.CreationTime}");
            //    Console.WriteLine($"File size: {file.Length}");
            //}
            //file.CopyTo(@"C:\Work\test2.txt", true);
            const string path = @"C:\Work\New folder";

            if (Directory.Exists(path))
            {
                //Directory.Move(path, @"C:\Work\222\Test");
                var dir = Directory.GetDirectories(path);
                foreach (var item in dir)
                {
                    //Console.WriteLine(item);
                }
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine();
                //Console.WriteLine();
                var files = Directory.GetFiles(path);
                foreach (var item in files)
                {
                    //Console.WriteLine(item);
                }
                DirectoryInfo di = new DirectoryInfo(path);
                if (di.Exists)
                {
                    var dirss = di.GetDirectories();
                    foreach (var item in dirss)
                    {
                        Console.WriteLine(item);
                    }
                }
                //remove directory with all data inside
                //di.Delete(true);
            }

            //var drives = DriveInfo.GetDrives();
            //foreach (var drive in drives)
            //{
            //    try
            //    {
            //        Console.WriteLine($"Name: {drive.Name}");
            //        Console.WriteLine($"Drive Type: {drive.DriveType}");
            //        Console.WriteLine($"Total Size: {drive.TotalSize / 1024 / 1024 / 1024}");
            //        Console.WriteLine($"Available Free Space: {drive.AvailableFreeSpace / 1024 / 1024 / 1024}");
            //        Console.WriteLine($"Total Free Space: {drive.TotalFreeSpace / 1024 / 1024 / 1024}");
            //        Console.WriteLine($"Drive Formet: {drive.DriveFormat}");

            //        drive.VolumeLabel = "Hello";
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("You don't have permissons to get/change info");
            //    }
            //}


            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] arr = Encoding.Default.GetBytes("Hello world!!!");
                fs.Write(arr, 0, arr.Length);
            }

            using (var fs = File.OpenRead(path))
            {
                byte[] arr = new byte[fs.Length];
                fs.Read(arr, 0, arr.Length);
                var res = Encoding.Default.GetString(arr);
                Console.WriteLine(res);
            }
        }
    }
}
