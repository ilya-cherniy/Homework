using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lect5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string path = @"C:\Work\test.json";
            //const string input = "Hello world!";

            //using (StreamWriter sw = new StreamWriter(path,false, Encoding.UTF7)) //false - delete all data from existing file and write new data
            //{
            //    sw.WriteLine(input);
            //}

            //using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF7)) //true - keep existind data and add new data into the existing file
            //{
            //    sw.Write("Today is Saturday");
            //    sw.WriteLine("18th Jan");
            //}

            //using (StreamReader sr = new StreamReader(path, Encoding.UTF7))
            //{
            //    var text = sr.ReadToEnd(); //read all file into the variable
            //    Console.WriteLine(text);

            //How to print only 2nd string in console    
            //int count = 1;
            //string line;
            //    while ((line = sr.ReadLine())!=null)
            //    {
            //  //      if (count==2)
            //    //    {
            //            Console.WriteLine(line);
            //           // break;
            //      //   }
            //        //count++;
            //    }

            // }
            //var persons = new Person[]{
            //    new Person("test1") {Name = "Name 1", Age = 30, CompanyName = "Google" },
            //    new Person("test2") {Name = "Name 2", Age = 25, CompanyName = "Apple" },
            //    new Person("test3") {Name = "Name 3", Age = 38, CompanyName = "Yahoo" },

            //};

            //using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            //{
            //    foreach (var person in persons)
            //    {
            //        bw.Write(person.Age);
            //        bw.Write(person.Name);
            //        bw.Write(person.CompanyName);
            //    }
            //}

            //using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open)))
            //{
            //    while (br.PeekChar() > -1)
            //    {
            //        var age = br.ReadInt32();
            //        var name = br.ReadString();
            //        var companyName = br.ReadString();
            //        Console.WriteLine($"{age}, {name}, {companyName}");
            //    }
            //}

            //var json = JsonConvert.SerializeObject(persons);

            //using (StreamWriter st = new StreamWriter(File.Open(path, FileMode.OpenOrCreate)))
            //{
            //    st.Write(json);
            //}

            //var outputPerson = JsonConvert.DeserializeObject<Person[]>(json);

            //ZipFile
            //GZipStream

            //const string source = @"C:\Work\test.txt";
            //const string commpressed = @"C:\Work\zipped.gz";
            //const string destination = @"C:\Work\output.txt";

            //Compress(source, commpressed);
            //Decompress(commpressed, destination);

            //Format string
            //var n = 24.15;
            //var t = 123;
            //Console.WriteLine(String.Format("{0:c5}", n));
            //Console.WriteLine(String.Format("{0:D4}", t));
            //Console.WriteLine(String.Format("{0:P1}", 0.1234m));
            //Console.WriteLine(String.Format("{0:+38(###)###-##-##}", 0501961421));
            //Console.ReadLine();
        }

        //private static void Decompress(string commpressed, string destination)
        //{
        //    using (FileStream fs = new FileStream(commpressed, FileMode.Open))
        //    {
        //        using (FileStream dfs = File.Create(destination))
        //        {
        //            using (GZipStream gzs = new GZipStream(fs, CompressionMode.Decompress))
        //            {
        //                gzs.CopyTo(dfs);
        //            }
        //        }
        //    }
        //}

        //private static void Compress(string source, string commpressed)
        //{
        //    using (FileStream fs = new FileStream(source, FileMode.OpenOrCreate))
        //    {
        //        using (FileStream dfs = File.Create(commpressed))
        //        {
        //            using (GZipStream gzs = new GZipStream(dfs, CompressionMode.Compress))
        //            {
        //                fs.CopyTo(gzs);
        //            }
        //        }
        //    }
        //}

    }
}
