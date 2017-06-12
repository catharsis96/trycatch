using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GracefullyHandlingExceptions
{
    class trycatch
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"D:\Lesson22\Exampl.txt");
                Console.WriteLine(content);
            }
            catch(Exception ex)
            {
                Console.WriteLine("There is a problem!");
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
