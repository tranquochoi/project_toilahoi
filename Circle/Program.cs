using System;

namespace Bai2_4
{
    //Khai báo lớp hình tròn
    public class Circle
    {
        public double _r;
        
        public double R
        {
            get{return _r;}
            set{_r = value;}
        }
        
        public Circle(double r = 0)
        {
            _r = r;
        }
        
        public Circle(Circle c)
        {
            _r = c._r;
        }
        
        ~Circle()
        {
            Console.WriteLine("The destructor was calles...");
        }
        
        public void Nhap()
        {
            Console.WriteLine("Nhap ban kinh r: ");
            _r = double.Parse(Console.ReadLine());
        }
        
        public double Area()
        {
            return _r * _r * (3.1416);
        }
    } // End of Circle class
    
    
    // Main program 
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Nhap();
            Console.WriteLine("Circle's Area = {0:F2}", c.Area());
            
            Circle c1 = new Circle(c);
            Console.WriteLine("Circle's Radius = {0:F2}", c.R);
            
        }
    } // End of class Program
}

