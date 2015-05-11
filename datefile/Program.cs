using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datefile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "datefile.txt");
            System.IO.File.AppendAllText(path,DateTime.Now.ToString()+"\r\n");
        }
    }
}
