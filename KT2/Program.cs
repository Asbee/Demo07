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
            string line;
            try
            {

                StreamWriter outputfile = new StreamWriter(@"D:\K2845\Demo07\KT2\integersnumbers.txt");
                StreamWriter outputfile2 = new StreamWriter(@":\K2845\Demo07\KT2\Doublenumbers.txt");
                do
                {
                    Console.Write("Give number (enter ends): ");
                    line = Console.ReadLine();
                    Console.WriteLine(line);
                    
                } while (line != "");

                double doubles;
              bool.parsed =  int.TryParse(line, out doubles)
                   
                
                outputfile.Close();
            } catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            } catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }

            
            try
            {

                string[] text = File.ReadAllLines(@"D:\K2845\Demo07\KT2\numbers.txt");
                foreach (string lines in text)
                {
                    Console.WriteLine(lines);
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
