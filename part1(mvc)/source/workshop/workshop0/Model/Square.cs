using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public partial class Square
    {
        public int Id { get; set; }
        public int A { get; set; }
        public double Area
        {
            get
            {
                return A * A;
            }
        }
    }
}
