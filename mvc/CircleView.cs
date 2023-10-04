using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CircleView
    {
        public int R { get; set; }
        public double Area { get; set; }
        //
        public void Read()
        {
            Console.Write("r = ");
            R = int.Parse(Console.ReadLine());
        }
        //
        public void Write()
        {
            Console.WriteLine("r = {0}, s = {1} ", R, Area);
        }       
    }
}
