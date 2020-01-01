using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Threading;

namespace StreamWorks
{
    class Program
    {
        private static bool whileKey = false;
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

            CustomReadWrite write = new CustomReadWrite("test.txt");
            string input;
            

            //Thread thread2 = new Thread(new ThreadStart(IsPushEscape));
            //thread2.Start();
            do
            {
                Console.Write("Code: ");
                input = Console.ReadLine();
                write.WriteBin(input);
            } while (!whileKey);
        }

        private static void IsPushEscape()
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                whileKey = key.Key == ConsoleKey.Escape ? true : false;
            } while (true);
        }



    }
}
