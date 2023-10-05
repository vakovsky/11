using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SquareView
    {
        public int A { get; set; }
        public double Area { get; set; }
        //
        public void Read()
        {
            Console.Write("a = ");
            A = int.Parse(Console.ReadLine());
        }
        //
        public void Write()
        {
            Console.WriteLine("a = {1}, s = {0} ", Area, A);
        }       
    }
}
