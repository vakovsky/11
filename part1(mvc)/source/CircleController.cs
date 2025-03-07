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
        List<Circle> circles;
        ViewCircle circleView;

        public CircleController()
        {
            circles = new List<Circle>();
            circleView = new ViewCircle();
            Menu();
        }

        private void Menu()
        {
            bool x = true;
            do
            {
                char c = circleView.Menu();
                switch (c)
                {
                    case 'c':
                        Create();
                        break;
                    case 'r':
                        Read();
                        break;
                    case 'u':
                        Update();
                        break;
                    case 'd':
                        Delete();
                        break;
                    case 'l':
                        List();
                        break;
                    case 'x':
                        x = false;
                        break;
                }
            } while (x);
        }

        private void Create()
        {
            Circle circle = new Circle();
            circleView.Read();
            circle.R = circleView.R;
            circles.Add(circle);
        }

        private void Read()
        {
            int Index = circleView.ReadIndex();
            Circle circle = circles[Index];
            circleView.R = circle.R;
            circleView.Area = circle.Area;
            circleView.Write();
        }

        private void Update()
        {
            int Index = circleView.ReadIndex();
            Circle circle = circles[Index];
            circleView.R = circle.R;
            circleView.Area = circle.Area;
            circleView.Write();
            circleView.Read();
            circle.R = circleView.R;
            circles[Index] = circle;
        }

        private void Delete()
        {
            int Index = circleView.ReadIndex();
            Circle circle = circles[Index];
            circleView.R = circle.R;
            circleView.Area = circle.Area;
            circleView.Write();
            circles.RemoveAt(Index);
        }

        private void List()
        {
            foreach (Circle circle in circles)
            {
                circleView.R = circle.R; ;
                circleView.Area = circle.Area;
                circleView.Write();
            }
        }
    }
}
