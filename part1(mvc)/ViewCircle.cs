using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ViewCircle
    {
        public int R { get; set; }
        public double Area { get; set; }
        public void Read()
        {
            Console.Write("R = ");
            R = int.Parse(Console.ReadLine());
        }
        public void Write()
        {
            Console.WriteLine("R = {0} Area = {1:f2}", R, Area);
        }
        public int ReadIndex()
        {
            Console.Write("Index = ");
            return int.Parse(Console.ReadLine());
        }
        public char Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("c -> Create Circle");
            Console.WriteLine("r -> Read Circle");
            Console.WriteLine("u -> Update Circle");
            Console.WriteLine("d -> Delete Circle");
            Console.WriteLine("l -> List");
            Console.WriteLine("x -> Exit");
            char c = Console.ReadKey(true).KeyChar;
            return c;
        }
    }
}
