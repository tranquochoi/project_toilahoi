using System;

    class Xe
    {
        string _bienSo;
        int _namSanXuat;
        double _giaTien;

        public double GiaTien
        {
            get => Convert.ToDouble(GiaTien);
        }

        public Xe()
        {
        }
        public Xe(string bienSo=" ", int namSX=0, double giaTien=0)
        {
            _bienSo = bienSo;
            _namSanXuat = namSX;
            _giaTien = giaTien;
        }

        public Xe(Xe x)
        {
            _bienSo = x._bienSo;
            _namSanXuat = x._namSanXuat;
            _giaTien = x._giaTien;
        }
        public void Input()
        {
            Console.Write("Bien so: ");
            _bienSo = Console.ReadLine();
            Console.Write("Nam san xuat: ");
            _namSanXuat = int.Parse(Console.ReadLine());
            Console.Write("Gia tien: ");
            _giaTien = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("=== INFO ===");
            Console.WriteLine("Bien So: {0}, Nam San Xuat: {1}, Gia tien: {2} Trieu Dong", _bienSo, _namSanXuat, _giaTien);
        }

        
       
    }
