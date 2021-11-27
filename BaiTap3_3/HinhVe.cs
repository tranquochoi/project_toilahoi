using System;

class HinhVe
{
    public string Ten{get; set;}
    public virtual double DienTich()
    {
        return 0;
    }

    public virtual void Input()
    {
        Console.Write(" ");
    }
  
}

class HinhThang: HinhVe
{
    private double _xA;
    private double _yA;
    private double _xB;
    private double _yB;
    private double _xC;
    private double _xD;

    public HinhThang(double xa=0, double ya=0, double xb=0, double yb=0, double xc=0, double xd=0)
    {
        _xA = xa;
        _yA = ya;
        _xB = xb;
        _yB = yb;
        _xC = xc;
        _xD = xd;
    }

    public override void Input()
    {
            Console.Write("Nhap xA: ");
            _xA = double.Parse(Console.ReadLine());
            Console.Write("Nhap yA: ");
            _yA = double.Parse(Console.ReadLine());
            Console.Write("Nhap xB: ");
            _xB = double.Parse(Console.ReadLine());
            Console.Write("Nhap yB: ");
            _yB = double.Parse(Console.ReadLine());
            Console.Write("Nhap xC: ");
            _xC = double.Parse(Console.ReadLine());
            Console.Write("Nhap xD: ");
            _xD = double.Parse(Console.ReadLine());
    }

    public override double DienTich()
    {
        return ((((_xC-_xB)+(_xD-_xA))/2) * (_yB-_yA));
    }
}

class HinhBinhHanh: HinhVe
{
    private double _yA;
    private double _xB;
    private double _yB;
    private double _xC;

    public HinhBinhHanh(double ya=0, double xb=0, double yb=0, double xc=0)
    {
        _yA = ya;
        _xB = xb;
        _yB = yb;
        _xC = xc;
    }

    

    public override void Input()
    {
        Console.Write("Nhap yA: ");
        _yA = double.Parse(Console.ReadLine());
        Console.Write("Nhap xB: ");
        _xB = double.Parse(Console.ReadLine());
        Console.Write("Nhap yB: ");
        _yB = double.Parse(Console.ReadLine());
        Console.Write("Nhap xC: ");
        _xC = double.Parse(Console.ReadLine());
    }

    public override double DienTich()
    {
        return ((_xC-_xB) * (_yB-_yA));
    }  
}

class HinhChuNhat:HinhVe
{
    private double _xA;
    private double _yA;
    private double _yB;
    private double _xC;

    public HinhChuNhat(double xa=0, double ya=0, double yb=0, double xc=0)
    {
        _xA = xa;
        _yA = ya;
        _yB = yb;
        _xC = xc;
    }

    public override void Input()
    {
        Console.Write("Nhap xA: ");
        _xA = double.Parse(Console.ReadLine());
        Console.Write("Nhap yA: ");
        _yA = double.Parse(Console.ReadLine());
        Console.Write("Nhap yB: ");
        _yB = double.Parse(Console.ReadLine());
        Console.Write("Nhap xC: ");
        _xC = double.Parse(Console.ReadLine());
    }

    public override double DienTich()
    {
        return  ((_xC-_xA) * (_yB-_yA));
    }
}

class HinhVuong: HinhVe
{
    private double _yA;
    private double _yB;

    public HinhVuong(double ya=0, double yb=0)
    {
        _yA = ya;
        _yB = yb;
    }

    public override void Input()
    {
        Console.Write("Nhap yA: ");
        _yA = double.Parse(Console.ReadLine());
        Console.Write("Nhap yB: ");
        _yB = double.Parse(Console.ReadLine());
    }

    public override double DienTich()
    {
        return ((_yB-_yA) * (_yB-_yA));
    }
}
