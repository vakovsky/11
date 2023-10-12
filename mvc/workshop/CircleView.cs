using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CircleView
    {
        public int Id { get; set; }
        public int R { get; set; }
        public double Area { get; set; }
        public string Command { get; set; }
        //
        public void Read()
        {
            Console.Write("r = ");
            R = int.Parse(Console.ReadLine());
        }
        //
        public void Write()
        {
            Console.WriteLine("{2} r = {0}, s = {1} ", R, Area, Id);
        }
        public void ReadIndex()
        {
            Console.Write("Id = ");
            Id = int.Parse(Console.ReadLine());
        }
        public void Help()
        {
            Console.WriteLine("help, list, create, select, delete, edit");
        }
        public void CNF()
        {
            Console.WriteLine("'{0}' is not recognized as an command", Command);
        }
        public void ReadCommand()
        {
            Console.Write("command>");
            Command = Console.ReadLine();
        }
    }
}
