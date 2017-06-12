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
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("There is a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly: Example.txt");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("There is a problem!");
                Console.WriteLine(@"Make sure the directory D:\Lesson22 exists");
            }
            //the most important catch, show you an issue
            catch (Exception ex)
            {
                Console.WriteLine("There is a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Code to finalize
                //Setting objects to null
                //Closing database connections
                Console.WriteLine("Closing application now ... ");
            }
        }
    }
}
