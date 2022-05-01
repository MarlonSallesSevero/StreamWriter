using System;
using System.IO;
namespace Using_Block
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\marlo\teste001.txt";
            string targetPath = @"C:\Users\marlo\teste002.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
