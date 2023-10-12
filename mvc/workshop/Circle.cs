using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Circle
    {
        public int Id { get; set; }
        public int R { get; set; }
        public double Area
        {
            get
            {
                return Math.PI * R * R;
            }
        }
    }
}
