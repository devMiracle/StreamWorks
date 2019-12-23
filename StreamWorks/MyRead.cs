using System;
using System.Collections.Generic;
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
        public int Read(byte[] array)
        {
            return 0;
        }
    }
}
