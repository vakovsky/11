using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    public class SquareController
    {
        Square square;
        SquareView view;
        public SquareController()
        {
            square = new Square();
            view = new SquareView();

            view.Read();

            square.A = view.A; //model <- view

            view.Area = square.Area; //view <- model

            view.Write();
        }
    }
}
