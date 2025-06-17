using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Circle
    {
        public int ID { get; set; }
        public int R { get; set; }
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(R, 2);
            }
        }
        public double Perimeter
        {
            get
            {
                return 2 * Math.PI * R;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} R({1}) Area({2}) Perimeter({3})",
                ID.ToString(),
                R.ToString(),
                Area.ToString("F2"),
                Perimeter.ToString("F2"));
        }
    }
}
