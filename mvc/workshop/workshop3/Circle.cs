using System;

namespace ClassLibrary1
{
    public class Circle
    {
        public int Id { get; set; }
        public int R { get; set; }
        public double Area
        {
            get
            {
                return Math.PI * R * R;
            }
        }

        public override string ToString()
        {
            return "Circle " + R.ToString() + " | " + Area.ToString();
        }

    }
}
