using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    public class RectController
    {
        Rect rect;
        RectView view;
        public RectController()
        {
            rect = new Rect();
            view = new RectView();

            view.Read();

            rect.A = view.A;
            rect.B = view.B;

            view.Area = rect.Area;

            view.Write();
        }
    }
}
