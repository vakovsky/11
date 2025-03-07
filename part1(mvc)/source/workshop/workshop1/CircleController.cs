using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp2
{
    public class CircleController
    {
        List<Circle> circles;
        CircleView view;

        public CircleController()
        {
            circles = new List<Circle>();
            view = new CircleView();
            do
            {
                view.ReadCommand();
                if (view.Command == "help")
                {
                    view.Help();
                }
                else
                if (view.Command == "list")
                {
                    Index();
                }
                else
                if (view.Command == "create")
                {
                    Create();
                }
                else
                if (view.Command == "select")
                {
                    view.ReadIndex();
                    Details(view.Id);
                }
                else
                if (view.Command == "delete")
                {
                    view.ReadIndex();
                    Delete(view.Id);
                }
                else
                if (view.Command == "edit")
                {
                    view.ReadIndex();
                    Edit(view.Id);
                }
                else
                {
                    view.CNF();
                }
            } while (true);
        }

        public void Create()
        {
            //
            view.Read();
            Circle circle = new Circle();
            circle.R = view.R;
            circles.Add(circle);
        }

        public void Index()
        {
            //
            for (int i = 0; i < circles.Count; i++)
            {
                Circle circle = circles[i];
                view.R = circle.R;
                view.Area = circle.Area;
                view.Id = i;
                view.Write();
            }
        }

        public void Details(int i)
        {
            Circle circle = circles[i];
            view.R = circle.R;
            view.Area = circle.Area;
            view.Id = i;
            view.Write();
        }

        public void Delete(int i)
        {
            Details(i);
            circles.RemoveAt(i);
        }

        public void Edit(int i)
        {
            Details(i);
            view.Read();
            circles[i].R = view.R;
        }

    }
}
