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
        public string ReadFile()
        {
            string text;
            using (FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                byte[] b = new byte[fs.Length];
                fs.Read(b, 0, (int)fs.Length);
                text = Encoding.UTF8.GetString(b);
            }
            return text;
        }
        public void WriteFile(string text)
        {
            using (FileStream fs = new FileStream(Path, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                byte[] b = Encoding.UTF8.GetBytes(text);
                fs.Write(b, 0, b.Length);
            }
        }
        public string ReadBin()
        {
            string text;
            List<string> textArray = new List<string>();
            using (BinaryReader br = new BinaryReader(File.Open(Path, FileMode.Open)))
            {
                while (br.PeekChar() > -1)
                {
                    text = br.ReadString();
                    textArray.Add(text);
                }
            }
            text = String.Concat(textArray);
            return text;
        }
        public void WriteBin(string text)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(Path, FileMode.Append, FileAccess.Write, FileShare.None)))
            {
                bw.Write(text + "\n");
            }
        }

    }
}
