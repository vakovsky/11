using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rect
    {
        public int A { get; set; }
        public int B { get; set; }
        public double Area
        {
            get
            {
                return A * B;
            }
        }
    }
}
