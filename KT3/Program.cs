using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3
{
    class Program
    {
        static void Main(string[] args)
        {


            TVProgram tvprogram1 = new TVProgram
            { Name = "Big Brother ", Channel = "MTV3 ", Time = "22.00 - 23.00", Info = "Tositv Draama" };
            TVProgram tvprogram2 = new TVProgram
            { Name = "Putous ", Channel = "Nelonen ", Time = "20.00 - 21.00", Info = "Putous on MTV3 Ohjelma, mutta nelonen näyttää sitä nyt" };
            TVProgram tvprogram3 = new TVProgram
            { Name = "A-Studio ", Channel = "YLE2 ", Time = "20.00 - 22.00", Info = "Keskustellaan ohjelmoinnista" };
            TVProgram tvprogram4 = new TVProgram
            { Name = "James Bond Spectre", Channel = "CMORE New", Time = "22.00 - 1.30", Info = "Action-elokuva" };

            StreamWriter outputfile = new StreamWriter(@"D:\K2845\Demo07\KT3\Programs.txt");

            outputfile.WriteLine(tvprogram1);
            outputfile.WriteLine(tvprogram2);
            outputfile.WriteLine(tvprogram3);
            outputfile.WriteLine(tvprogram4);
            outputfile.Close();

            string text = File.ReadAllText(@"D:\K2845\Demo07\KT3\Programs.txt");

            Console.WriteLine(tvprogram1);
            Console.WriteLine(tvprogram2);
            Console.WriteLine(tvprogram3);
            Console.WriteLine(tvprogram4);
           




        }
    }
}
