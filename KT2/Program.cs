using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class Program
    {
        static void Main(string[] args)
        {
            double doubles;
            int integers;
            string line;
            try
            {

                StreamWriter outputfile = new StreamWriter(@"D:\K2845\Demo07\KT2\integersnumbers.txt");
                StreamWriter outputfile2 = new StreamWriter(@"D:\K2845\Demo07\KT2\Doublenumbers.txt");
                do
                {
                    Console.Write("Give number (enter ends): ");
                    line = Console.ReadLine();

                   bool succes = int.TryParse(line, out integers);
                    if (!succes)
                    {
                        double.TryParse(line, out doubles);
                        outputfile2.WriteLine(doubles);
                    }
                    else
                    {
                        outputfile.WriteLine(integers);
                    }
                   
                    
                } while (line != "");

        

                outputfile2.Close();
                outputfile.Close();
               
            } catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            } 

            
            try
            {

                string[] text = File.ReadAllLines(@"D:\K2845\Demo07\KT2\Doublenumbers.txt");
                string[] text2 = File.ReadAllLines(@"D:\K2845\Demo07\KT2\integersnumbers.txt");
                foreach (string lines in text)
                {
                    Console.WriteLine(lines);
                }
                foreach (string lines2 in text2)
                {
                    Console.WriteLine(lines2);
                }
            }catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
            
             
            
            
           

        }
    }
}
