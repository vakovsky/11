using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RectView
    {
        public int A { get; set; }
        public int B { get; set; }
        public double Area { get; set; }
        //
        public void Read()
        {
            Console.Write("a = ");
            A = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            B = int.Parse(Console.ReadLine());
        }
        //
        public void Write()
        {
            Console.WriteLine("a = {0}, b = {1}, s = {2} ", A, B, Area);
        }       
    }
}
