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
            CustomReadWrite write = new CustomReadWrite("text.dat");
            string input;
            

            do
            {
                Console.Write("Text: ");
                input = Console.ReadLine();
                write.WriteBin(input);
                whileKey = true;
            } while (!whileKey);

            Console.WriteLine(write.ReadBin());

        }
        



    }
}
