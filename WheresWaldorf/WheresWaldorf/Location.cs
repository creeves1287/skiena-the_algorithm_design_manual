using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheresWaldorf
{
    public class Location
    {
        public Location(int line, int column)
        {
            Line = line;
            Column = column;
        }
        public int Line { get; set; }
        public int Column { get; set; }
    }
}
