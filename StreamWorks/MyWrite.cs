using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWorks
{
    class CustomWrite
    {
        public string Path { get; set; }
        public CustomWrite(string path)
        {
            Path = path;
        }
        public void Write(string[] text)
        {
            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                byte[] b;
                for (int i = 0; i < text.Length; i++)
                {
                    b = Encoding.UTF8.GetBytes(text[i] + "\n");
                    fs.Write(b, 0, b.Length);
                }
            }
        }
    }
}
