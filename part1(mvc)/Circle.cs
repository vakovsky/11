using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Circle
    {
        public int R { get; set; }
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(R, 2);
            }
        }
        public override string ToString()
        {
            return R.ToString("F2") + " " + Area.ToString("F2");
        }
    }
}
