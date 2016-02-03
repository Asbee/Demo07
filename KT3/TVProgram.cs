using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3
{
    class TVProgram
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public string Info { get; set; }
        public string Time { get; set; }

        public override string ToString()
        {
            return Name + " " + Channel + " " + Time + " " + Info;

        }
    }
}
