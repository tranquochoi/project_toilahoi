using System;

namespace Distance_OOP
{
    public class Point
    {
        private double _x;
        private double _y;

        public double X
        {
            get{return _x;}
            set{_x = value;}
        }

        public double Y
        {
            get{return _y;}
            set{_y = value;}
        }

        public Point(double x = 0, double y = 0)
        {
            _x = x;
            _y = y;
        }

        public Point(Point p)
        {
            _x = p._x;
            _y = p._y;
        }

        ~Point()
        {
            Console.WriteLine("Destroyed...");
        }

        public void Input()
        {
            Console.Write("Nhap Hoanh Do (x): ");
            _x = double.Parse(Console.ReadLine());
            Console.Write("Nhap Trung Do (y): ");
            _y = double.Parse(Console.ReadLine());

        }

        public void Output()
        {
            Console.WriteLine("Display: ({0}, {1})", _x, _y);
        }

        public void Move(double dx, double dy)
        {
            _x += dx;
            _y += dy;
        }

        public double Distance(Point another)
        {
            return Math.Sqrt(Math.Pow(_x - another._x, 2) + Math.Pow(_y - another._y, 2));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.Input();
            p.Output();

            p.Move(3, -4);
            Console.WriteLine("==> TOA DO SAU KHI DICH CHUYEN <==");
            p.Output();


            Point p1 = new Point(4, 5);
            Point p2 = new Point(8, 9);

            double distance = p1.Distance(p2);
            Console.WriteLine("Distance: {0:F2}", distance);

            Console.ReadLine();
        }
    }
}

