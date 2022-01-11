using System;
using System.IO;

namespace Filhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Filhantering\Filhantering\hello.txt";


            using (StreamWriter sw = File.CreateText(path))
            {
                Console.WriteLine("Vad heter du");
                sw.WriteLine(Console.ReadLine());
               
            }

            using (StreamReader sr = File.OpenText(path))
            {
              string s;
              s = sr.ReadLine();
                    Console.WriteLine("tryck enter för att läsa upp texten");
                    Console.WriteLine(Console.ReadLine()); 
                    Console.WriteLine(s);         
                 
            }

        }
    }
}
