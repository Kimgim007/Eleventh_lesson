using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleventh_lesson
{
    public class Point
    {
        public Point() { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x { get; set; }
        public int y { get; set; }

        public void WherePoint()
        {
            Console.WriteLine($"Координаты точки по оси - x {x}, по оси y {y}");
        }
    }
}
