using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWorks
{
    class CustomReadWrite
    {
        public string Path { get; set; }
        public CustomReadWrite(string path)
        {
            Path = path;
        }
        public string[] ReadFile()
        {
            string text;
            using (FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                byte[] b = new byte[fs.Length];
                fs.Read(b, 0, (int)fs.Length);
                text = Encoding.UTF8.GetString(b);
            }
            return new string[1] { text };
        }
        public void WriteFile(string text)
        {
            using (FileStream fs = new FileStream(Path, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                byte[] b;
                for (int i = 0; i < text.Length; i++)
                {
                    b = Encoding.UTF8.GetBytes(text[i] + "\n");
                    fs.Write(b, 0, b.Length);
                }
            }
        }
        public void WriteBin(string text)
        {
            if (Path.Skip(Path.IndexOf('.')).ToString() == ".txt")
            {
                Console.WriteLine("путь имеет расширение .txt");
                Console.ReadKey(true);
            }
            using (FileStream str = new FileStream(Path, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                byte[] b = Encoding.UTF8.GetBytes(text);
                using (BinaryWriter bw = new BinaryWriter(str))
                {
                    bw.Write(b);
                    Console.WriteLine("done!");
                    Console.WriteLine("doneTwo!");
                }
            }

        }
    }
}
