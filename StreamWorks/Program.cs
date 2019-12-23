using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace StreamWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfo fileInfo2 = new FileInfo("test.txt");
            //fileInfo2.Create();
            //FileInfo fileInfo3 = new FileInfo("test.txt");
            //fileInfo3.Create();

            //string text = Console.ReadLine();
            //string path = "test.bin";
            //FileInfo fileInfo = new FileInfo(path);
            //using (FileStream fs = fileInfo.Open(FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    byte[] b = Encoding.Unicode.GetBytes(text);
            //    fs.Write(b, 0, b.Length);
            //}

            //Console.WriteLine("Write done.");
            //Console.ReadKey(true);

            //string readText;
            //using (FileStream fs = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.None))
            //{
            //    byte[] b = new byte[fs.Length];
            //    fs.Read(b, 0, b.Length);

            //    readText = Encoding.Unicode.GetString(b);
            //}
            //Console.WriteLine(readText);
            ////File.Delete(path);
            //Console.ReadKey(true);

            CustomWrite write = new CustomWrite("test.txt");
            write.Write(new string[] { "привет", "мир" });

        }
    }
}
