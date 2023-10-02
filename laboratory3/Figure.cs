using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory3
{
    public class Figure
    {
        private Point[] points;

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3, p4 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 };
        }

        private double GetDistance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        public void CalculatePerimeter()
        {
            if (points.Length < 3)
            {
                Console.WriteLine("Потрiбно щонайменше 3 точки для обчислення периметру.");
                return;
            }

            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += GetDistance(points[i], points[i + 1]);
            }
            perimeter += GetDistance(points[points.Length - 1], points[0]);

            Console.WriteLine($"Назва фiгури: {points[0].Name}");
            Console.WriteLine($"Периметр фiгури: {perimeter}");
        }
    }
}
