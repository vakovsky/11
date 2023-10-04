using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    public class CircleController
    {
        Circle circle;
        CircleView view;
        public CircleController()
        {
            circle = new Circle();
            view = new CircleView();

            view.Read();

            circle.R = view.R; //view -> model

            view.Area = circle.Area; //model -> view

            view.Write();
        }
    }
}
