using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            
            StreamWriter outputfile = new StreamWriter(@"D:\K2845\Demo07\test.txt");

            do
            {
                Console.Write("Write textlines: ");
                line = Console.ReadLine();
                outputfile.WriteLine(line);


            } while (line != "");

            outputfile.Close();
            
            try
            {
                
                string[] text = File.ReadAllLines (@"D:\K2845\Demo07\test.txt");
                foreach (string lines in text)
                {
                   Console.WriteLine(lines);
                }
                
                
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
