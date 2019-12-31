using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWorks
{
    class CustomRead
    {
        public string Path { get; set; }
        public CustomRead(string path)
        {
            Path = path;
        }
        public string[] Read()
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
    }
}
